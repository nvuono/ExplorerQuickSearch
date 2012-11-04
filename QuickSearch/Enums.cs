using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace QuickSearch
{
    public static class AttributeExtensions
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute attribute
                    = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
                        as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }
    }

    /// <summary>
    /// These elements define the union of the "kind" of items that should appear in the library.
    /// </summary>
    public enum UnionKinds
    {
        Calendar, Communication, Contact,
        Document, Email, Feed,
        Folder, Game, InstantMessage,
        Journal, Link, Movie,
        Music, Note, Picture,
        Program, RecordedTv, Searchfolder,
        Task, Video, WebHistory,
        Item, Other
    }

    /// <summary>
    /// Conditions are filters against which search results are compared. For example, you can filter results that meet certain criteria, like author name or file size. The set of conditions are built into a single condition tree with logical AND, OR and NOT branches.
    /// 
    /// &lt;query&gt;
    ///    ...
    ///    &lt;conditions&gt;
    ///        &lt;condition type="" ...&gt;
    ///            &lt;attributes&gt;
    ///                &lt;attribute attributeID="" .../&gt;
    ///            &lt;/attributes&gt;
    ///        &lt;/condition&gt;
    ///    &lt;/conditions&gt;
    ///&lt;/query&gt;
    /// </summary>
    public enum Conditions
    {
        /// <summary>
        /// Conjunction of two or more child conditions
        /// </summary>
        andCondition,
        /// <summary>
        /// Disjunction of two of more child conditions
        /// </summary>
        orCondition,
        /// <summary>
        /// Negation of a child condition
        /// </summary>
        notCondition,
        /// <summary>
        /// Compares a property to value.
        /// Has Attributes: property, propertyType, operator, value, valuetype
        /// </summary>
        leafCondition
    }


    /// <summary>
    /// Different possible column types from http://msdn.microsoft.com/en-us/library/windows/desktop/ff521735(v=vs.85).aspx
    /// </summary>
    public enum ColumnTypes
    {
        // There's probably an enum somewhere in the framework I could've accessed instead of adding this enum
        [Description("System.AcquisitionID")]
        System_AcquisitionID,

        [Description("System.ApplicationName")]
        System_ApplicationName,

        [Description("System.Author")]
        System_Author,

        [Description("System.Capacity")]
        System_Capacity,

        [Description("System.Category")]
        System_Category,

        [Description("System.Comment")]
        System_Comment,

        [Description("System.Company")]
        System_Company,

        [Description("System.ComputerName")]
        System_ComputerName,

        [Description("System.ContainedItems")]
        System_ContainedItems,

        [Description("System.ContentStatus")]
        System_ContentStatus,

        [Description("System.ContentType")]
        System_ContentType,

        [Description("System.Copyright")]
        System_Copyright,

        [Description("System.DateAccessed")]
        System_DateAccessed,

        [Description("System.DateAcquired")]
        System_DateAcquired,

        [Description("System.DateArchived")]
        System_DateArchived,

        [Description("System.DateCompleted")]
        System_DateCompleted,

        [Description("System.DateCreated")]
        System_DateCreated,

        [Description("System.DateImported")]
        System_DateImported,

        [Description("System.DateModified")]
        System_DateModified,

        [Description("System.DueDate")]
        System_DueDate,

        [Description("System.EndDate")]
        System_EndDate,

        [Description("System.FileAllocationSize")]
        System_FileAllocationSize,

        [Description("System.FileAttributes")]
        System_FileAttributes,

        [Description("System.FileCount")]
        System_FileCount,

        [Description("System.FileDescription")]
        System_FileDescription,

        [Description("System.FileExtension")]
        System_FileExtension,

        [Description("System.FileFRN")]
        System_FileFRN,

        [Description("System.FileName")]
        System_FileName,

        [Description("System.FileOwner")]
        System_FileOwner,

        [Description("System.FileVersion")]
        System_FileVersion,

        [Description("System.FindData")]
        System_FindData,

        [Description("System.FlagColor")]
        System_FlagColor,

        [Description("System.FlagColorText")]
        System_FlagColorText,

        [Description("System.FlagStatus")]
        System_FlagStatus,

        [Description("System.FlagStatusText")]
        System_FlagStatusText,

        [Description("System.FreeSpace")]
        System_FreeSpace,

        [Description("System.FullText")]
        System_FullText,

        [Description("System.Identity")]
        System_Identity,

        [Description("System.Identity.Blob")]
        System_Identity_Blob,

        [Description("System.Identity.DisplayName")]
        System_Identity_DisplayName,

        [Description("System.Identity.IsMeIdentity")]
        System_Identity_IsMeIdentity,

        [Description("System.Identity.PrimaryEmailAddress")]
        System_Identity_PrimaryEmailAddress,

        [Description("System.Identity.ProviderID")]
        System_Identity_ProviderID,

        [Description("System.Identity.UniqueID")]
        System_Identity_UniqueID,

        [Description("System.Identity.UserName")]
        System_Identity_UserName,

        [Description("System.IdentityProvider.Name")]
        System_IdentityProvider_Name,

        [Description("System.IdentityProvider.Picture")]
        System_IdentityProvider_Picture,

        [Description("System.ImageParsingName")]
        System_ImageParsingName,

        [Description("System.Importance")]
        System_Importance,

        [Description("System.ImportanceText")]
        System_ImportanceText,

        [Description("System.IsAttachment")]
        System_IsAttachment,

        [Description("System.IsDefaultNonOwnerSaveLocation")]
        System_IsDefaultNonOwnerSaveLocation,

        [Description("System.IsDefaultSaveLocation")]
        System_IsDefaultSaveLocation,

        [Description("System.IsDeleted")]
        System_IsDeleted,

        [Description("System.IsEncrypted")]
        System_IsEncrypted,

        [Description("System.IsFlagged")]
        System_IsFlagged,

        [Description("System.IsFlaggedComplete")]
        System_IsFlaggedComplete,

        [Description("System.IsIncomplete")]
        System_IsIncomplete,

        [Description("System.IsLocationSupported")]
        System_IsLocationSupported,

        [Description("System.IsPinnedToNameSpaceTree")]
        System_IsPinnedToNameSpaceTree,

        [Description("System.IsRead")]
        System_IsRead,

        [Description("System.IsSearchOnlyItem")]
        System_IsSearchOnlyItem,

        [Description("System.IsSendToTarget")]
        System_IsSendToTarget,

        [Description("System.IsShared")]
        System_IsShared,

        [Description("System.ItemAuthors")]
        System_ItemAuthors,

        [Description("System.ItemClassType")]
        System_ItemClassType,

        [Description("System.ItemDate")]
        System_ItemDate,

        [Description("System.ItemFolderNameDisplay")]
        System_ItemFolderNameDisplay,

        [Description("System.ItemFolderPathDisplay")]
        System_ItemFolderPathDisplay,

        [Description("System.ItemFolderPathDisplayNarrow")]
        System_ItemFolderPathDisplayNarrow,

        [Description("System.ItemName")]
        System_ItemName,

        [Description("System.ItemNameDisplay")]
        System_ItemNameDisplay,

        [Description("System.ItemNamePrefix")]
        System_ItemNamePrefix,

        [Description("System.ItemParticipants")]
        System_ItemParticipants,

        [Description("System.ItemPathDisplay")]
        System_ItemPathDisplay,

        [Description("System.ItemPathDisplayNarrow")]
        System_ItemPathDisplayNarrow,

        [Description("System.ItemType")]
        System_ItemType,

        [Description("System.ItemTypeText")]
        System_ItemTypeText,

        [Description("System.ItemUrl")]
        System_ItemUrl,

        [Description("System.Keywords")]
        System_Keywords,

        [Description("System.Kind")]
        System_Kind,

        [Description("System.KindText")]
        System_KindText,

        [Description("System.Language")]
        System_Language,

        [Description("System.LayoutPattern.ContentViewModeForBrowse")]
        System_LayoutPattern_ContentViewModeForBrowse,

        [Description("System.LayoutPattern.ContentViewModeForSearch")]
        System_LayoutPattern_ContentViewModeForSearch,

        [Description("System.MileageInformation")]
        System_MileageInformation,

        [Description("System.MIMEType")]
        System_MIMEType,

        [Description("System.Null")]
        System_Null,

        [Description("System.OfflineAvailability")]
        System_OfflineAvailability,

        [Description("System.OfflineStatus")]
        System_OfflineStatus,

        [Description("System.OriginalFileName")]
        System_OriginalFileName,

        [Description("System.OwnerSID")]
        System_OwnerSID,

        [Description("System.ParentalRating")]
        System_ParentalRating,

        [Description("System.ParentalRatingReason")]
        System_ParentalRatingReason,

        [Description("System.ParentalRatingsOrganization")]
        System_ParentalRatingsOrganization,

        [Description("System.ParsingBindContext")]
        System_ParsingBindContext,

        [Description("System.ParsingName")]
        System_ParsingName,

        [Description("System.ParsingPath")]
        System_ParsingPath,

        [Description("System.PerceivedType")]
        System_PerceivedType,

        [Description("System.PercentFull")]
        System_PercentFull,

        [Description("System.Priority")]
        System_Priority,

        [Description("System.PriorityText")]
        System_PriorityText,

        [Description("System.Project")]
        System_Project,

        [Description("System.ProviderItemID")]
        System_ProviderItemID,

        [Description("System.Rating")]
        System_Rating,

        [Description("System.RatingText")]
        System_RatingText,

        [Description("System.Sensitivity")]
        System_Sensitivity,

        [Description("System.SensitivityText")]
        System_SensitivityText,

        [Description("System.SFGAOFlags")]
        System_SFGAOFlags,

        [Description("System.SharedWith")]
        System_SharedWith,

        [Description("System.ShareUserRating")]
        System_ShareUserRating,

        [Description("System.SharingStatus")]
        System_SharingStatus,

        [Description("System.Shell.OmitFromView")]
        System_Shell_OmitFromView,

        [Description("System.SimpleRating")]
        System_SimpleRating,

        [Description("System.Size")]
        System_Size,

        [Description("System.SoftwareUsed")]
        System_SoftwareUsed,

        [Description("System.SourceItem")]
        System_SourceItem,

        [Description("System.StartDate")]
        System_StartDate,

        [Description("System.Status")]
        System_Status,

        [Description("System.Subject")]
        System_Subject,

        [Description("System.Thumbnail")]
        System_Thumbnail,

        [Description("System.ThumbnailCacheId")]
        System_ThumbnailCacheId,

        [Description("System.ThumbnailStream")]
        System_ThumbnailStream,

        [Description("System.Title")]
        System_Title,

        [Description("System.TotalFileSize")]
        System_TotalFileSize,

        [Description("System.Trademarks")]
        System_Trademarks
    }
}
