using QuantumSpatial.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSpatial.Common
{
    public class LoginResponce
    {


        public class Client
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailAddress { get; set; }
            public string CreatedAt { get; set; }
            public string ModifiedAt { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public string title { get; set; }
            public string subTitle { get; set; }
            public string logo { get; set; }
            public string geometryService { get; set; }
            public object GeometryServiceUserId { get; set; }
            public object GeometryServicePwd { get; set; }
            public List<object> ClientServers { get; set; }
            public string ContactPerson { get; set; }
            public string ContactPersonPhoneNumber { get; set; }
            public int NumberOfUsers { get; set; }
            public string Structure_Inspection_Lock_Id { get; set; }
            public object LockCycle { get; set; }
            public object LockTime { get; set; }
        }

        public class Extent
        {
            public double xmin { get; set; }
            public double ymin { get; set; }
            public double xmax { get; set; }
            public double ymax { get; set; }
        }

        public class MapOptions
        {
            public Extent extent { get; set; }
            public string basemap { get; set; }
        }

        public class Map
        {
            public MapOptions mapOptions { get; set; }
        }

        public class Widget
        {
            public string name { get; set; }
            public string label { get; set; }
        }

        public class WidgetPool
        {
            public List<Widget> widgets { get; set; }
        }

        public class VegInspection
        {
            public int access { get; set; }
            public int viewOnly { get; set; }
            public int viewAndEdit { get; set; }
            public string basemapURL { get; set; }
            public string featureServiceURL { get; set; }
            public string ambitURL { get; set; }
            public string inspectionURL { get; set; }
        }

        public class HereSdk
        {
            public string appId { get; set; }
            public string appCode { get; set; }
            public string licenseKey { get; set; }
        }

        public class FacilityInspection
        {
            public int access { get; set; }
            public int viewOnly { get; set; }
            public int viewAndEdit { get; set; }
            public string basemapURL { get; set; }
            public string featureServiceURL { get; set; }
            public string ambitURL { get; set; }
            public string structureURL { get; set; }
            public string transmissionURL { get; set; }
            public string supportedStructureURL { get; set; }
            public string footPrintsURL { get; set; }
            public string poleURL { get; set; }
            public HereSdk hereSdk { get; set; }
        }

        public class FootPrint
        {
            public int layerId { get; set; }
            public int distanceFilterMeters { get; set; }
        }

        public class Configuration
        {
            public int chunkSize { get; set; }
            public bool showReport { get; set; }
            public string workOrderType { get; set; }
            public FootPrint footPrint { get; set; }
        }

        public class MyStateAmbit
        {
        }

        public class Credentials
        {
            public string username { get; set; }
            public string password { get; set; }
        }

        public class License
        {
            public string clientID { get; set; }
            public string keyChainIdentifier { get; set; }
            public string portalURL { get; set; }
        }

        public class Credentials2
        {
            public string username { get; set; }
            public string password { get; set; }
        }

        public class License2
        {
            public string clientID { get; set; }
            public string keyChainIdentifier { get; set; }
            public string portalURL { get; set; }
        }

        public class List
        {
            public string name { get; set; }
            public string url { get; set; }
            public string provider { get; set; }
            public bool needCredentials { get; set; }
            public bool needLicense { get; set; }
            public Credentials2 credentials { get; set; }
            public License2 license { get; set; }
            public string key { get; set; }
        }

        public class BaseMap
        {
            public string name { get; set; }
            public string url { get; set; }
            public string provider { get; set; }
            public bool needCredentials { get; set; }
            public bool needLicense { get; set; }
            public Credentials credentials { get; set; }
            public License license { get; set; }
            public List<List> list { get; set; }
        }

        public class Ambit
        {
            public string url { get; set; }
        }

        public class Credentials3
        {
            public string username { get; set; }
            public string password { get; set; }
        }

        public class Security
        {
            public string proxy { get; set; }
            public Credentials3 credentials { get; set; }
        }

        public class OperationStatusFieldValue
        {
            public string value { get; set; }
            public string label { get; set; }
            public string color { get; set; }
        }

        public class SummaryCalloutProp
        {
            public string value { get; set; }
            public string label { get; set; }
            public string type { get; set; }
        }

        public class Feature
        {
            public int featureId { get; set; }
            public string idField { get; set; }
            public string name { get; set; }
            public string pluralName { get; set; }
            public string displayField { get; set; }
            public string operationStatusField { get; set; }
            public string defaultOperationStatusValue { get; set; }
            public string operationProgressStatusField { get; set; }
            public List<OperationStatusFieldValue> operationStatusFieldValues { get; set; }
            public List<SummaryCalloutProp> summaryCalloutProps { get; set; }
        }

        public class Layer
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool render { get; set; }
            public bool initialVisibility { get; set; }
            public bool operational { get; set; }
            public int featureId { get; set; }
            public int ordinality { get; set; }
            public bool toBeInList { get; set; }
        }

        public class FeatureService
        {
            public string url { get; set; }
            public List<Feature> features { get; set; }
            public List<Layer> layers { get; set; }
        }

        public class FacilityManagement
        {
            public Configuration configuration { get; set; }
            public MyStateAmbit myStateAmbit { get; set; }
            public BaseMap baseMap { get; set; }
            public Ambit ambit { get; set; }
            public Security security { get; set; }
            public List<FeatureService> featureServices { get; set; }
        }

        public class IOSModules
        {
            public VegInspection __invalid_name__Veg_Inspection { get; set; }
            public FacilityInspection FacilityInspection { get; set; }
            public FacilityManagement FacilityManagement { get; set; }
        }

        public class ModulePermissions
        {
            public Map map { get; set; }
            public WidgetPool widgetPool { get; set; }
            public IOSModules __invalid_name__iOS_Modules { get; set; }
        }

        public class UserGroup
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string ClientId { get; set; }
            public ModulePermissions ModulePermissions { get; set; }
            public string MapPermissions { get; set; }
            public string UserType { get; set; }
            public string CreatedAt { get; set; }
            public string ModifiedAt { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
        }

        public class UserDetails
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public string ContactNumber { get; set; }
            public string EmailAddress { get; set; }
            public string Password { get; set; }
            public string UserGroupId { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string EffectiveDate { get; set; }
            public object ExpirationDate { get; set; }
            public object EffectiveFrom { get; set; }
            public object EffectiveTo { get; set; }
            public bool IsActive { get; set; }
            public string Token { get; set; }
            public string CreatedAt { get; set; }
            public string ModifiedAt { get; set; }
            public string PASSWORD_UPDATED_DATE { get; set; }
            public string CreatedBy { get; set; }
            public string ModifiedBy { get; set; }
            public string clientId { get; set; }
            public Client Client { get; set; }
            public UserGroup UserGroup { get; set; }
            public object ErrorMessage { get; set; }
            public object Status { get; set; }
            public object UserPreference { get; set; }
            public object UserData { get; set; }
            public object ShareWidgets { get; set; }
            public bool IsFirstLoginAfterReset { get; set; }
            public string Organization { get; set; }
            public string Organization_Name { get; set; }
            public bool IsGeneric { get; set; }
            public string OrganizationType { get; set; }
            public object Privilege { get; set; }
            public string NavigateURL { get; set; }
            public string LoginToken { get; set; }
            public object LoginURL { get; set; }
            public string UserManagementServiceAddress { get; set; }
            public string GeoSpatialServiceAddress { get; set; }
            public object UserBusinessDomain { get; set; }
            public object County_Id { get; set; }
            public object AppicationModuleMaster { get; set; }
            public bool PasswordExpired { get; set; }
            public int PasswordRemainingDays { get; set; }
            public bool TFAEnabled { get; set; }
            public string PasswordExpirationDate { get; set; }
            public int passwordNotificationDays { get; set; }
            public string LockCycle { get; set; }
            public string LockTime { get; set; }
        }

        public class GetValidMobileUserResult
        {
            public UserDetails UserDetails { get; set; }
            public object UserGroupId { get; set; }
        }

        public class RootObject
        {
            public GetValidMobileUserResult GetValidMobileUserResult { get; set; }
        }
    }
}