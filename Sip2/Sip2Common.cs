using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sip2Service.SIP2
{
    public class Sip2Common
    {
        public const string EndOfMessage = "\n";
        #region
        public const string PatronStatusRequest = "23";
        public const string PatronStatusResponse = "24";
        public const string CheckoutRequest = "11";
        public const string CheckoutResponse = "12";
        public const string CheckinRequest = "09";
        public const string CheckinResponse = "10";
        public const string BlockPatronRequest = "01";
        public const string SCStatusRequest = "99";
        public const string ACSResendRequest = "97";
        public const string LoginRequest = "93";
        public const string LoginResponse = "94";
        public const string PatronInformationRequest = "63";
        public const string PatronInformationResponse = "64";
        public const string EndPatronSessionRequest = "35";
        public const string EndPatronSessionResponse = "36";
        public const string FeePaidRequest = "37";
        public const string FeePaidResponse = "38";
        public const string ItemInformationRequest = "17";
        public const string ItemInformationResponse = "18";
        public const string ItemStatusUpdateRequest = "19";
        public const string ItemStatusUpdateResponse = "20";
        public const string PatronEnableRequest = "25";
        public const string PatronEnableRequestResponse = "26";
        public const string HoldRequest = "15";
        public const string HoldResponse = "16";
        public const string RenewRequest = "29";
        public const string RenewResponse = "30";
        public const string RenewAllRequest = "65";
        public const string RenewAllResponse = "66";
        #endregion

        //Field
        #region
        public const string PatronIdentifier = "AA";
        public const string ItemIdentifier = "AB";
        public const string TerminalPassword = "AC";
        public const string PatronPassword = "AD";
        public const string PersonalName = "AE";
        public const string ScreenMessage = "AF";
        public const string DueDate = "AH";
        public const string TitleIdentifier = "AJ";
        public const string ISBNCode = "AK";
        public const string InstitutionId = "AO";
        public const string HoldItems = "AS";
        public const string OverdueItems = "AT";
        public const string ChargedItems = "AU";
        public const string Author = "AW";
        public const string SequenceNumber = "AY";
        public const string CheckSum = "AZ";

        public const string FeeAcknowledged = "BO";
        public const string StartItem = "BP";
        public const string EndItem = "BQ";
        public const string HoldItemsLimit = "BZ";

        public const string OverdueItemsLimit = "CA";
        public const string ChargedItemsLimit = "CB";
        public const string ItemProperties = "CH";
        public const string ReturnDate = "CJ";
        public const string MediaType = "CK";
        public const string LoginUserId = "CN";
        public const string HoldPickupDate = "CM";
        public const string LoginPassword = "CO";
        public const string LocationCode = "CP";
        public const string ValidPatronPassword = "CQ";

        public const string LocationType = "KC";
        public const string PermanentLocation = "AQ";
        public const string CurrentLocation = "AP";

        public const string Press = "PB";

        public const string BorrowDateNum = "QX";

        public const string VendorProfile = "VP";

        public const string PatronType = "XT";
        #endregion

    }
}
