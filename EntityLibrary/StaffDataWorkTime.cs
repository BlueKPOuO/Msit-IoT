//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class StaffDataWorkTime
    {
        public string StaffID { get; set; }
        public string StaffName { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<System.DateTime> LeaveDate { get; set; }
        public string StaffPhone { get; set; }
        public string StaffLINE_ID { get; set; }
        public bool OnWork { get; set; }
        public string ShiftID { get; set; }
        public string WorkTime { get; set; }
    }
}
