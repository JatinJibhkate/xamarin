using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSpatial.Common
{
    public class InspectionResponce
    {
        public class AssignedDate
        {
            public string Date { get; set; }
            public string Month { get; set; }
            public string Year { get; set; }
        }

        public class CreatedDate
        {
            public string Date { get; set; }
            public string Month { get; set; }
            public string Year { get; set; }
        }

        public class WORKORDEROBJECTLINK
        {
            public string OBJECT_ID { get; set; }
            public string WO_ID { get; set; }
            public string ID { get; set; }
            public object DETECTION_STATUS { get; set; }
            public object DETECTION_TYPE { get; set; }
            public object INSPECTION_DATE { get; set; }
            public string INSPECTIONDATE { get; set; }
            public string OBJECT_TYPE_ID { get; set; }
            public string OBJECT_STATUS_ID { get; set; }
            public object OBJECT_INSPECT_DATE { get; set; }
            public string OBJECT_INSPECTION_STATUS_ID { get; set; }
            public string INSPECTION_STATUS { get; set; }
            public object PROGRESS_STATUS { get; set; }
            public object SWITCH_ID { get; set; }
            public object STRUCTURE_DETAILS { get; set; }
        }

        public class Result
        {
            public string WOId { get; set; }
            public string WONumber { get; set; }
            public string WOName { get; set; }
            public string CreatedById { get; set; }
            public string AssignedToId { get; set; }
            public AssignedDate AssignedDate { get; set; }
            public CreatedDate CreatedDate { get; set; }
            public string WOStatus { get; set; }
            public string WOType { get; set; }
            public string WOTags { get; set; }
            public string AmbitId { get; set; }
            public string AmbitName { get; set; }
            public object DueDate { get; set; }
            public string CreatedByUserName { get; set; }
            public string AssignedToUserName { get; set; }
            public int NUM_DETECTIONS { get; set; }
            public object PARENT_WO_GUID { get; set; }
            public List<WORKORDEROBJECTLINK> WORKORDEROBJECTLINKS { get; set; }
            public string WO_STATUS_ID { get; set; }
            public string WO_TYPE_ID { get; set; }
            public object INSPECT_TYPE_ID { get; set; }
            public object INSPECT_TYPE { get; set; }
            public object WOInspectType { get; set; }
            public object WOSTATUSDATE { get; set; }
            public bool IS_DELETED { get; set; }
            public object CREATED_DATE { get; set; }
            public object DUE_DATE { get; set; }
            public object ASSIGNED_DATE { get; set; }
            public object WO_STATUS_DATE { get; set; }
            public string WO_CREW { get; set; }
            public object INSPECTION_PROGRAM { get; set; }
            public int NUM_STRUCTURES { get; set; }
            public int NUM_SWITCHES { get; set; }
        }

        public class RootObject
        {
            public List<Result> Result { get; set; }
        }
    }
}
