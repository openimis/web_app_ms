

IF NOT OBJECT_ID('uspGetPolicyRenewals') IS NULL
DROP PROCEDURE uspGetPolicyRenewals
GO
CREATE PROCEDURE [dbo].[uspGetPolicyRenewals]
(
@OfficerCode NVARCHAR(8)
)
AS
BEGIN
	DECLARE @OfficerId INT
	DECLARE @LegacyOfficer INT

	DECLARE @tblOfficerSub TABLE(OldOfficer INT, NewOfficer INT)

	SELECT @OfficerId = OfficerID FROM tblOfficer WHERE Code= @OfficerCode AND ValidityTo IS NULL
			INSERT INTO @tblOfficerSub(OldOfficer, NewOfficer) 
			SELECT DISTINCT @OfficerID, @OfficerID 

			SET @LegacyOfficer = (SELECT OfficerID FROM tblOfficer WHERE ValidityTo IS NULL AND OfficerIDSubst = @OfficerID)
			WHILE @LegacyOfficer IS NOT NULL
				BEGIN
					INSERT INTO @tblOfficerSub(OldOfficer, NewOfficer) 
					SELECT DISTINCT @OfficerID, @LegacyOfficer 
					IF EXISTS(SELECT 1 FROM @tblOfficerSub  GROUP BY NewOfficer HAVING COUNT(1) > 1)
						BREAK;
					SET @LegacyOfficer = (SELECT OfficerID FROM tblOfficer WHERE ValidityTo IS NULL AND OfficerIDSubst = @LegacyOfficer)
				END;



       -- ;WITH FollowingPolicies AS ( SELECT P.PolicyId, P.FamilyId, ISNULL(Prod.ConversionProdId, Prod.ProdId)ProdID, P.StartDate FROM tblPolicy P INNER JOIN tblProduct Prod ON P.ProdId = ISNULL(Prod.ConversionProdId, Prod.ProdId) WHERE P.ValidityTo IS NULL AND Prod.ValidityTo IS NULL ) 

	        SELECT R.RenewalId,R.PolicyId, O.OfficerId, O.Code OfficerCode, I.CHFID, I.LastName, I.OtherNames, Prod.ProductCode, Prod.ProductName,F.LocationId, V.VillageName, CONVERT(NVARCHAR(10),R.RenewalpromptDate,103)RenewalpromptDate, O.Phone, CONVERT(NVARCHAR(10),RenewalDate,103) EnrollDate, PL.PolicyStage, F.FamilyID, Prod.ProdID

			FROM tblPolicy PL 
			INNER JOIN tblPolicyRenewals R ON PL.PolicyId = R.PolicyId AND R.ValidityTo IS NULL
			INNER JOIN tblOfficer O ON R.NewOfficerId = O.OfficerId AND O.ValidityTo IS NULL
			INNER JOIN tblFamilies F ON PL.FamilyId = F.FamilyID AND F.ValidityTo IS NULL
			INNER JOIN tblInsuree I ON F.InsureeId = I.InsureeID  AND I.ValidityTo IS NULL
			INNER JOIN tblProduct Prod ON PL.ProdId = Prod.ProdID
			INNER JOIN tblVillages V ON V.VillageId = F.LocationId AND V.ValidityTo IS NULL
			INNER JOIN tblWards W ON W.WardId = V.WardId AND W.ValidityTo IS NULL
			INNER JOIN tblDistricts D ON D.DistrictID = W.DistrictID AND D.ValidityTo IS NULL 
			INNER JOIN tblRegions Rg ON Rg.RegionId = D.Region AND Rg.ValidityTo IS NULL
			--INNER JOIN tblOfficer O ON O.OfficerID = PL.OfficerID
			INNER JOIN @tblOfficerSub OS ON OS.NewOfficer = R.NewOfficerID
	      --  LEFT OUTER JOIN FollowingPolicies FP ON FP.FamilyID = F.FamilyId AND FP.ProdId = PL.ProdID AND FP.PolicyId <> R.PolicyID 
	
			WHERE PL.ValidityTo IS NULL
			AND O.Code = @OfficerCode
			AND (PL.PolicyStatus > 1)
	 
 END
 GO

