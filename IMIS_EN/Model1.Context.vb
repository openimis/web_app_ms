﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class IMISEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=IMISEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property tblBatchRun() As DbSet(Of tblBatchRun)
    Public Overridable Property tblCeilingInterpretation() As DbSet(Of tblCeilingInterpretation)
    Public Overridable Property tblClaim() As DbSet(Of tblClaim)
    Public Overridable Property tblClaimAdmin() As DbSet(Of tblClaimAdmin)
    Public Overridable Property tblClaimDedRem() As DbSet(Of tblClaimDedRem)
    Public Overridable Property tblClaimItems() As DbSet(Of tblClaimItems)
    Public Overridable Property tblClaimServices() As DbSet(Of tblClaimServices)
    Public Overridable Property tblConfirmationTypes() As DbSet(Of tblConfirmationTypes)
    Public Overridable Property tblControls() As DbSet(Of tblControls)
    Public Overridable Property tblEducations() As DbSet(Of tblEducations)
    Public Overridable Property tblEmailSettings() As DbSet(Of tblEmailSettings)
    Public Overridable Property tblExtracts() As DbSet(Of tblExtracts)
    Public Overridable Property tblFamilies() As DbSet(Of tblFamilies)
    Public Overridable Property tblFamilyTypes() As DbSet(Of tblFamilyTypes)
    Public Overridable Property tblFeedback() As DbSet(Of tblFeedback)
    Public Overridable Property tblFeedbackPrompt() As DbSet(Of tblFeedbackPrompt)
    Public Overridable Property tblFromPhone() As DbSet(Of tblFromPhone)
    Public Overridable Property tblHealthStatus() As DbSet(Of tblHealthStatus)
    Public Overridable Property tblHF() As DbSet(Of tblHF)
    Public Overridable Property tblHFCatchment() As DbSet(Of tblHFCatchment)
    Public Overridable Property tblHFSublevel() As DbSet(Of tblHFSublevel)
    Public Overridable Property tblICDCodes() As DbSet(Of tblICDCodes)
    Public Overridable Property tblIdentificationTypes() As DbSet(Of tblIdentificationTypes)
    Public Overridable Property tblIMISDefaults() As DbSet(Of tblIMISDefaults)
    Public Overridable Property tblInsuree() As DbSet(Of tblInsuree)
    Public Overridable Property tblInsureePolicy() As DbSet(Of tblInsureePolicy)
    Public Overridable Property tblItems() As DbSet(Of tblItems)
    Public Overridable Property tblLanguages() As DbSet(Of tblLanguages)
    Public Overridable Property tblLegalForms() As DbSet(Of tblLegalForms)
    Public Overridable Property tblLocations() As DbSet(Of tblLocations)
    Public Overridable Property tblLogins() As DbSet(Of tblLogins)
    Public Overridable Property tblOfficer() As DbSet(Of tblOfficer)
    Public Overridable Property tblOfficerVillages() As DbSet(Of tblOfficerVillages)
    Public Overridable Property tblPayer() As DbSet(Of tblPayer)
    Public Overridable Property tblPayerType() As DbSet(Of tblPayerType)
    Public Overridable Property tblPhotos() As DbSet(Of tblPhotos)
    Public Overridable Property tblPLItems() As DbSet(Of tblPLItems)
    Public Overridable Property tblPLItemsDetail() As DbSet(Of tblPLItemsDetail)
    Public Overridable Property tblPLServices() As DbSet(Of tblPLServices)
    Public Overridable Property tblPLServicesDetail() As DbSet(Of tblPLServicesDetail)
    Public Overridable Property tblPolicy() As DbSet(Of tblPolicy)
    Public Overridable Property tblPolicyRenewalDetails() As DbSet(Of tblPolicyRenewalDetails)
    Public Overridable Property tblPolicyRenewals() As DbSet(Of tblPolicyRenewals)
    Public Overridable Property tblPremium() As DbSet(Of tblPremium)
    Public Overridable Property tblProduct() As DbSet(Of tblProduct)
    Public Overridable Property tblProductItems() As DbSet(Of tblProductItems)
    Public Overridable Property tblProductServices() As DbSet(Of tblProductServices)
    Public Overridable Property tblProfessions() As DbSet(Of tblProfessions)
    Public Overridable Property tblRelations() As DbSet(Of tblRelations)
    Public Overridable Property tblRelDistr() As DbSet(Of tblRelDistr)
    Public Overridable Property tblRelIndex() As DbSet(Of tblRelIndex)
    Public Overridable Property tblReporting() As DbSet(Of tblReporting)
    Public Overridable Property tblServices() As DbSet(Of tblServices)
    Public Overridable Property tblSubmittedPhotos() As DbSet(Of tblSubmittedPhotos)
    Public Overridable Property tblUsers() As DbSet(Of tblUsers)
    Public Overridable Property tblUsersDistricts() As DbSet(Of tblUsersDistricts)

End Class