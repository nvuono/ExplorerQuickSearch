using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace QuickSearch
{
    enum DesktopSearchProperties
    {

        [Description("System.Author")]
        System_Author,

        [Description("System.Category")]
        System_Category,

        [Description("System.Comment")]
        System_Comment,

        [Description("System.Company")]
        System_Company,

        [Description("System.ComputerName")]
        System_ComputerName,

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

        [Description("System.FileAttributes")]
        System_FileAttributes,

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

        [Description("System.FlagColor")]
        System_FlagColor,

        [Description("System.FlagColorText")]
        System_FlagColorText,

        [Description("System.FlagStatus")]
        System_FlagStatus,

        [Description("System.FlagStatusText")]
        System_FlagStatusText,

        [Description("System.Identity")]
        System_Identity,

        [Description("System.Importance")]
        System_Importance,

        [Description("System.ImportanceText")]
        System_ImportanceText,

        [Description("System.IsAttachment")]
        System_IsAttachment,

        [Description("System.IsDeleted")]
        System_IsDeleted,

        [Description("System.IsFlagged")]
        System_IsFlagged,

        [Description("System.IsFlaggedComplete")]
        System_IsFlaggedComplete,

        [Description("System.IsIncomplete")]
        System_IsIncomplete,

        [Description("System.IsRead")]
        System_IsRead,

        [Description("System.IsShared")]
        System_IsShared,

        [Description("System.ItemAuthors")]
        System_ItemAuthors,

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

        [Description("System.Journal.Contacts")]
        System_Journal_Contacts,

        [Description("System.Journal.EntryType")]
        System_Journal_EntryType,

        [Description("System.Keywords")]
        System_Keywords,

        [Description("System.Kind")]
        System_Kind,

        [Description("System.KindText")]
        System_KindText,

        [Description("System.Language")]
        System_Language,

        [Description("System.MileageInformation")]
        System_MileageInformation,

        [Description("System.MIMEType")]
        System_MIMEType,

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

        [Description("System.Shell.OmitFromView")]
        System_Shell_OmitFromView,

        [Description("System.Shell.SFGAOFlagsStrings")]
        System_Shell_SFGAOFlagsStrings,

        [Description("System.Size")]
        System_Size,

        [Description("System.Software.DateLastUsed")]
        System_Software_DateLastUsed,

        [Description("System.Software.ProductName")]
        System_Software_ProductName,

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

        [Description("System.ThumbnailCacheId")]
        System_ThumbnailCacheId,

        [Description("System.Title")]
        System_Title,

        [Description("System.OriginalFileName")]
        System_OriginalFileName,

        [Description("System.ParentalRating")]
        System_ParentalRating,

        [Description("System.ParentalRatingReason")]
        System_ParentalRatingReason,

        [Description("System.ParsingName")]
        System_ParsingName,

        [Description("System.Audio.ChannelCount")]
        System_Audio_ChannelCount,

        [Description("System.Audio.EncodingBitrate")]
        System_Audio_EncodingBitrate,

        [Description("System.Audio.PeakValue")]
        System_Audio_PeakValue,

        [Description("System.Audio.SampleRate")]
        System_Audio_SampleRate,

        [Description("System.Audio.SampleSize")]
        System_Audio_SampleSize,

        [Description("System.Photo.Aperture")]
        System_Photo_Aperture,

        [Description("System.Photo.CameraManufacturer")]
        System_Photo_CameraManufacturer,

        [Description("System.Photo.CameraModel")]
        System_Photo_CameraModel,

        [Description("System.Photo.ContrastText")]
        System_Photo_ContrastText,

        [Description("System.Photo.DateTaken")]
        System_Photo_DateTaken,

        [Description("System.Photo.Event")]
        System_Photo_Event,

        [Description("System.Photo.ExposureProgram")]
        System_Photo_ExposureProgram,

        [Description("System.Photo.ExposureProgramText")]
        System_Photo_ExposureProgramText,

        [Description("System.Photo.ExposureTime")]
        System_Photo_ExposureTime,

        [Description("System.Photo.Flash")]
        System_Photo_Flash,

        [Description("System.Photo.FlashText")]
        System_Photo_FlashText,

        [Description("System.Photo.FNumber")]
        System_Photo_FNumber,

        [Description("System.Photo.FocalLength")]
        System_Photo_FocalLength,

        [Description("System.Photo.GainControlText")]
        System_Photo_GainControlText,

        [Description("System.Photo.ISOSpeed")]
        System_Photo_ISOSpeed,

        [Description("System.Photo.MeteringMode")]
        System_Photo_MeteringMode,

        [Description("System.Photo.MeteringModeText")]
        System_Photo_MeteringModeText,

        [Description("System.Photo.Orientation")]
        System_Photo_Orientation,

        [Description("System.Photo.OrientationText")]
        System_Photo_OrientationText,

        [Description("System.Photo.PhotometricInterpretationText")]
        System_Photo_PhotometricInterpretationText,

        [Description("System.Photo.ProgramModeText")]
        System_Photo_ProgramModeText,

        [Description("System.Photo.SaturationText")]
        System_Photo_SaturationText,

        [Description("System.Photo.SharpnessText")]
        System_Photo_SharpnessText,

        [Description("System.Photo.ShutterSpeed")]
        System_Photo_ShutterSpeed,

        [Description("System.Photo.WhiteBalanceText")]
        System_Photo_WhiteBalanceText,

        [Description("System.Image.BitDepth")]
        System_Image_BitDepth,

        [Description("System.Image.Compression")]
        System_Image_Compression,

        [Description("System.Image.CompressionText")]
        System_Image_CompressionText,

        [Description("System.Image.Dimensions")]
        System_Image_Dimensions,

        [Description("System.Image.HorizontalResolution")]
        System_Image_HorizontalResolution,

        [Description("System.Image.HorizontalSize")]
        System_Image_HorizontalSize,

        [Description("System.Image.VerticalResolution")]
        System_Image_VerticalResolution,

        [Description("System.Image.VerticalSize")]
        System_Image_VerticalSize,

        [Description("System.Media.AverageLevel")]
        System_Media_AverageLevel,

        [Description("System.Media.ClassPrimaryID")]
        System_Media_ClassPrimaryID,

        [Description("System.Media.ClassSecondaryID")]
        System_Media_ClassSecondaryID,

        [Description("System.Media.CollectionGroupID")]
        System_Media_CollectionGroupID,

        [Description("System.Media.CollectionID")]
        System_Media_CollectionID,

        [Description("System.Media.ContentDistributor")]
        System_Media_ContentDistributor,

        [Description("System.Media.ContentID")]
        System_Media_ContentID,

        [Description("System.Media.CreatorApplication")]
        System_Media_CreatorApplication,

        [Description("System.Media.CreatorApplicationVersion")]
        System_Media_CreatorApplicationVersion,

        [Description("System.Media.DateEncoded")]
        System_Media_DateEncoded,

        [Description("System.Media.DateReleased")]
        System_Media_DateReleased,

        [Description("System.Media.Duration")]
        System_Media_Duration,

        [Description("System.Media.DVDID")]
        System_Media_DVDID,

        [Description("System.Media.EncodedBy")]
        System_Media_EncodedBy,

        [Description("System.Media.FrameCount")]
        System_Media_FrameCount,

        [Description("System.Media.MCDI")]
        System_Media_MCDI,

        [Description("System.Media.MetadataContentProvider")]
        System_Media_MetadataContentProvider,

        [Description("System.Media.Producer")]
        System_Media_Producer,

        [Description("System.Media.ProtectionType")]
        System_Media_ProtectionType,

        [Description("System.Media.ProviderRating")]
        System_Media_ProviderRating,

        [Description("System.Media.ProviderStyle")]
        System_Media_ProviderStyle,

        [Description("System.Media.Publisher")]
        System_Media_Publisher,

        [Description("System.Media.SubscriptionContentId")]
        System_Media_SubscriptionContentId,

        [Description("System.Media.SubTitle")]
        System_Media_SubTitle,

        [Description("System.Media.UniqueFileIdentifier")]
        System_Media_UniqueFileIdentifier,

        [Description("System.Media.UserNoAutoInfo")]
        System_Media_UserNoAutoInfo,

        [Description("System.Media.UserWebUrl")]
        System_Media_UserWebUrl,

        [Description("System.Media.Writer")]
        System_Media_Writer,

        [Description("System.Media.Year")]
        System_Media_Year,

        [Description("System.Document.ByteCount")]
        System_Document_ByteCount,

        [Description("System.Document.CharacterCount")]
        System_Document_CharacterCount,

        [Description("System.Document.ClientID")]
        System_Document_ClientID,

        [Description("System.Document.Contributor")]
        System_Document_Contributor,

        [Description("System.Document.DateCreated")]
        System_Document_DateCreated,

        [Description("System.Document.DatePrinted")]
        System_Document_DatePrinted,

        [Description("System.Document.DateSaved")]
        System_Document_DateSaved,

        [Description("System.Document.Division")]
        System_Document_Division,

        [Description("System.Document.DocumentID")]
        System_Document_DocumentID,

        [Description("System.Document.HiddenSlideCount")]
        System_Document_HiddenSlideCount,

        [Description("System.Document.LastAuthor")]
        System_Document_LastAuthor,

        [Description("System.Document.LineCount")]
        System_Document_LineCount,

        [Description("System.Document.Manager")]
        System_Document_Manager,

        [Description("System.Document.PageCount")]
        System_Document_PageCount,

        [Description("System.Document.ParagraphCount")]
        System_Document_ParagraphCount,

        [Description("System.Document.PresentationFormat")]
        System_Document_PresentationFormat,

        [Description("System.Document.RevisionNumber")]
        System_Document_RevisionNumber,

        [Description("System.Document.SlideCount")]
        System_Document_SlideCount,

        [Description("System.Document.TotalEditingTime")]
        System_Document_TotalEditingTime,

        [Description("System.Document.WordCount")]
        System_Document_WordCount,

        [Description("System.Music.AlbumArtist")]
        System_Music_AlbumArtist,

        [Description("System.Music.AlbumTitle")]
        System_Music_AlbumTitle,

        [Description("System.Music.Artist")]
        System_Music_Artist,

        [Description("System.Music.BeatsPerMinute")]
        System_Music_BeatsPerMinute,

        [Description("System.Music.Composer")]
        System_Music_Composer,

        [Description("System.Music.Conductor")]
        System_Music_Conductor,

        [Description("System.Music.ContentGroupDescription")]
        System_Music_ContentGroupDescription,

        [Description("System.Music.Genre")]
        System_Music_Genre,

        [Description("System.Music.InitialKey")]
        System_Music_InitialKey,

        [Description("System.Music.Lyrics")]
        System_Music_Lyrics,

        [Description("System.Music.Mood")]
        System_Music_Mood,

        [Description("System.Music.PartOfSet")]
        System_Music_PartOfSet,

        [Description("System.Music.Period")]
        System_Music_Period,

        [Description("System.Music.TrackNumber")]
        System_Music_TrackNumber,

        [Description("System.Calendar.Duration")]
        System_Calendar_Duration,

        [Description("System.Calendar.IsOnline")]
        System_Calendar_IsOnline,

        [Description("System.Calendar.IsRecurring")]
        System_Calendar_IsRecurring,

        [Description("System.Calendar.Location")]
        System_Calendar_Location,

        [Description("System.Calendar.OptionalAttendeeAddresses")]
        System_Calendar_OptionalAttendeeAddresses,

        [Description("System.Calendar.OptionalAttendeeNames")]
        System_Calendar_OptionalAttendeeNames,

        [Description("System.Calendar.OrganizerAddress")]
        System_Calendar_OrganizerAddress,

        [Description("System.Calendar.OrganizerName")]
        System_Calendar_OrganizerName,

        [Description("System.Calendar.ReminderTime")]
        System_Calendar_ReminderTime,

        [Description("System.Calendar.RequiredAttendeeAddresses")]
        System_Calendar_RequiredAttendeeAddresses,

        [Description("System.Calendar.RequiredAttendeeNames")]
        System_Calendar_RequiredAttendeeNames,

        [Description("System.Calendar.Resources")]
        System_Calendar_Resources,

        [Description("System.Calendar.ShowTimeAs")]
        System_Calendar_ShowTimeAs,

        [Description("System.Calendar.ShowTimeAsText")]
        System_Calendar_ShowTimeAsText,

        [Description("System.Contact.Anniversary")]
        System_Contact_Anniversary,

        [Description("System.Contact.AssistantName")]
        System_Contact_AssistantName,

        [Description("System.Contact.AssistantTelephone")]
        System_Contact_AssistantTelephone,

        [Description("System.Contact.Birthday")]
        System_Contact_Birthday,

        [Description("System.Contact.BusinessAddress")]
        System_Contact_BusinessAddress,

        [Description("System.Contact.BusinessAddressCity")]
        System_Contact_BusinessAddressCity,

        [Description("System.Contact.BusinessAddressCountry")]
        System_Contact_BusinessAddressCountry,

        [Description("System.Contact.BusinessAddressPostalCode")]
        System_Contact_BusinessAddressPostalCode,

        [Description("System.Contact.BusinessAddressPostOfficeBox")]
        System_Contact_BusinessAddressPostOfficeBox,

        [Description("System.Contact.BusinessAddressState")]
        System_Contact_BusinessAddressState,

        [Description("System.Contact.BusinessAddressStreet")]
        System_Contact_BusinessAddressStreet,

        [Description("System.Contact.BusinessFaxNumber")]
        System_Contact_BusinessFaxNumber,

        [Description("System.Contact.BusinessHomePage")]
        System_Contact_BusinessHomePage,

        [Description("System.Contact.BusinessTelephone")]
        System_Contact_BusinessTelephone,

        [Description("System.Contact.CallbackTelephone")]
        System_Contact_CallbackTelephone,

        [Description("System.Contact.CarTelephone")]
        System_Contact_CarTelephone,

        [Description("System.Contact.Children")]
        System_Contact_Children,

        [Description("System.Contact.CompanyMainTelephone")]
        System_Contact_CompanyMainTelephone,

        [Description("System.Contact.Department")]
        System_Contact_Department,

        [Description("System.Contact.EmailAddress")]
        System_Contact_EmailAddress,

        [Description("System.Contact.EmailAddress2")]
        System_Contact_EmailAddress2,

        [Description("System.Contact.EmailAddress3")]
        System_Contact_EmailAddress3,

        [Description("System.Contact.EmailAddresses")]
        System_Contact_EmailAddresses,

        [Description("System.Contact.EmailName")]
        System_Contact_EmailName,

        [Description("System.Contact.FileAsName")]
        System_Contact_FileAsName,

        [Description("System.Contact.FirstName")]
        System_Contact_FirstName,

        [Description("System.Contact.FullName")]
        System_Contact_FullName,

        [Description("System.Contact.Gender")]
        System_Contact_Gender,

        [Description("System.Contact.Hobbies")]
        System_Contact_Hobbies,

        [Description("System.Contact.HomeAddress")]
        System_Contact_HomeAddress,

        [Description("System.Contact.HomeAddressCity")]
        System_Contact_HomeAddressCity,

        [Description("System.Contact.HomeAddressCountry")]
        System_Contact_HomeAddressCountry,

        [Description("System.Contact.HomeAddressPostalCode")]
        System_Contact_HomeAddressPostalCode,

        [Description("System.Contact.HomeAddressPostOfficeBox")]
        System_Contact_HomeAddressPostOfficeBox,

        [Description("System.Contact.HomeAddressState")]
        System_Contact_HomeAddressState,

        [Description("System.Contact.HomeAddressStreet")]
        System_Contact_HomeAddressStreet,

        [Description("System.Contact.HomeFaxNumber")]
        System_Contact_HomeFaxNumber,

        [Description("System.Contact.HomeTelephone")]
        System_Contact_HomeTelephone,

        [Description("System.Contact.IMAddress")]
        System_Contact_IMAddress,

        [Description("System.Contact.JA.CompanyNamePhonetic")]
        System_Contact_JA_CompanyNamePhonetic,

        [Description("System.Contact.JA.FirstNamePhonetic")]
        System_Contact_JA_FirstNamePhonetic,

        [Description("System.Contact.JA.LastNamePhonetic")]
        System_Contact_JA_LastNamePhonetic,

        [Description("System.Contact.JobTitle")]
        System_Contact_JobTitle,

        [Description("System.Contact.Label")]
        System_Contact_Label,

        [Description("System.Contact.LastName")]
        System_Contact_LastName,

        [Description("System.Contact.MailingAddress")]
        System_Contact_MailingAddress,

        [Description("System.Contact.MiddleName")]
        System_Contact_MiddleName,

        [Description("System.Contact.MobileTelephone")]
        System_Contact_MobileTelephone,

        [Description("System.Contact.NickName")]
        System_Contact_NickName,

        [Description("System.Contact.OfficeLocation")]
        System_Contact_OfficeLocation,

        [Description("System.Contact.OtherAddress")]
        System_Contact_OtherAddress,

        [Description("System.Contact.OtherAddressCity")]
        System_Contact_OtherAddressCity,

        [Description("System.Contact.OtherAddressCountry")]
        System_Contact_OtherAddressCountry,

        [Description("System.Contact.OtherAddressPostalCode")]
        System_Contact_OtherAddressPostalCode,

        [Description("System.Contact.OtherAddressPostOfficeBox")]
        System_Contact_OtherAddressPostOfficeBox,

        [Description("System.Contact.OtherAddressState")]
        System_Contact_OtherAddressState,

        [Description("System.Contact.OtherAddressStreet")]
        System_Contact_OtherAddressStreet,

        [Description("System.Contact.PagerTelephone")]
        System_Contact_PagerTelephone,

        [Description("System.Contact.PersonalTitle")]
        System_Contact_PersonalTitle,

        [Description("System.Contact.PrimaryAddressCity")]
        System_Contact_PrimaryAddressCity,

        [Description("System.Contact.PrimaryAddressCountry")]
        System_Contact_PrimaryAddressCountry,

        [Description("System.Contact.PrimaryAddressPostalCode")]
        System_Contact_PrimaryAddressPostalCode,

        [Description("System.Contact.PrimaryAddressPostOfficeBox")]
        System_Contact_PrimaryAddressPostOfficeBox,

        [Description("System.Contact.PrimaryAddressState")]
        System_Contact_PrimaryAddressState,

        [Description("System.Contact.PrimaryAddressStreet")]
        System_Contact_PrimaryAddressStreet,

        [Description("System.Contact.PrimaryEmailAddress")]
        System_Contact_PrimaryEmailAddress,

        [Description("System.Contact.PrimaryTelephone")]
        System_Contact_PrimaryTelephone,

        [Description("System.Contact.Profession")]
        System_Contact_Profession,

        [Description("System.Contact.SpouseName")]
        System_Contact_SpouseName,

        [Description("System.Contact.Suffix")]
        System_Contact_Suffix,

        [Description("System.Contact.TelexNumber")]
        System_Contact_TelexNumber,

        [Description("System.Contact.TTYTDDTelephone")]
        System_Contact_TTYTDDTelephone,

        [Description("System.Contact.WebPage")]
        System_Contact_WebPage,

        [Description("System.Message.AttachmentContents")]
        System_Message_AttachmentContents,

        [Description("System.Message.AttachmentNames")]
        System_Message_AttachmentNames,

        [Description("System.Message.BccAddress")]
        System_Message_BccAddress,

        [Description("System.Message.BccName")]
        System_Message_BccName,

        [Description("System.Message.CcAddress")]
        System_Message_CcAddress,

        [Description("System.Message.CcName")]
        System_Message_CcName,

        [Description("System.Message.ConversationID")]
        System_Message_ConversationID,

        [Description("System.Message.ConversationIndex")]
        System_Message_ConversationIndex,

        [Description("System.Message.DateReceived")]
        System_Message_DateReceived,

        [Description("System.Message.DateSent")]
        System_Message_DateSent,

        [Description("System.Message.FromAddress")]
        System_Message_FromAddress,

        [Description("System.Message.FromName")]
        System_Message_FromName,

        [Description("System.Message.HasAttachments")]
        System_Message_HasAttachments,

        [Description("System.Message.IsFwdOrReply")]
        System_Message_IsFwdOrReply,

        [Description("System.Message.MessageClass")]
        System_Message_MessageClass,

        [Description("System.Message.SenderAddress")]
        System_Message_SenderAddress,

        [Description("System.Message.SenderName")]
        System_Message_SenderName,

        [Description("System.Message.Store")]
        System_Message_Store,

        [Description("System.Message.ToAddress")]
        System_Message_ToAddress,

        [Description("System.Message.ToDoTitle")]
        System_Message_ToDoTitle,

        [Description("System.Message.ToName")]
        System_Message_ToName,

        [Description("System.Note.Color")]
        System_Note_Color,

        [Description("System.Note.ColorText")]
        System_Note_ColorText,

        [Description("System.Task.BillingInformation")]
        System_Task_BillingInformation,

        [Description("System.Task.CompletionStatus")]
        System_Task_CompletionStatus,

        [Description("System.Task.Owner")]
        System_Task_Owner,

        [Description("System.RecordedTV.ChannelNumber")]
        System_RecordedTV_ChannelNumber,

        [Description("System.RecordedTV.DateContentExpires")]
        System_RecordedTV_DateContentExpires,

        [Description("System.RecordedTV.EpisodeName")]
        System_RecordedTV_EpisodeName,

        [Description("System.RecordedTV.IsATSCContent")]
        System_RecordedTV_IsATSCContent,

        [Description("System.RecordedTV.IsClosedCaptioningAvailable")]
        System_RecordedTV_IsClosedCaptioningAvailable,

        [Description("System.RecordedTV.IsDTVContent")]
        System_RecordedTV_IsDTVContent,

        [Description("System.RecordedTV.IsHDContent")]
        System_RecordedTV_IsHDContent,

        [Description("System.RecordedTV.IsRepeatBroadcast")]
        System_RecordedTV_IsRepeatBroadcast,

        [Description("System.RecordedTV.IsSAP")]
        System_RecordedTV_IsSAP,

        [Description("System.RecordedTV.OriginalBroadcastDate")]
        System_RecordedTV_OriginalBroadcastDate,

        [Description("System.RecordedTV.ProgramDescription")]
        System_RecordedTV_ProgramDescription,

        [Description("System.RecordedTV.RecordingTime")]
        System_RecordedTV_RecordingTime,

        [Description("System.RecordedTV.StationCallSign")]
        System_RecordedTV_StationCallSign,

        [Description("System.RecordedTV.StationName")]
        System_RecordedTV_StationName,

        [Description("System.Search.AutoSummary")]
        System_Search_AutoSummary,

        [Description("System.Search.Rank")]
        System_Search_Rank,

        [Description("System.Video.Compression")]
        System_Video_Compression,

        [Description("System.Video.Director")]
        System_Video_Director,

        [Description("System.Video.EncodingBitrate")]
        System_Video_EncodingBitrate,

        [Description("System.Video.FourCC")]
        System_Video_FourCC,

        [Description("System.Video.FrameHeight")]
        System_Video_FrameHeight,

        [Description("System.Video.FrameRate")]
        System_Video_FrameRate,

        [Description("System.Video.FrameWidth")]
        System_Video_FrameWidth,

        [Description("System.Video.HorizontalAspectRatio")]
        System_Video_HorizontalAspectRatio,

        [Description("System.Video.SampleSize")]
        System_Video_SampleSize,

        [Description("System.Video.StreamName")]
        System_Video_StreamName,

        [Description("System.Video.TotalBitrate")]
        System_Video_TotalBitrate,

        [Description("System.Video.VerticalAspectRatio")]
        System_Video_VerticalAspectRatio
    }
}
