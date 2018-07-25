using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTaker
{
    enum IOU_STATE
    {
        CHECKED,
        TIMEOVERED,
        CLOSED
    };  //추가 필요

    class IOU
    {
        private string name;
        private int cost;
        private DateTime enrollDate;    //등록일
        private DateTime startDate;     //시작일
        private DateTime endDate;       //마감일
        private int state;              //상태 (enum)
        private String memo;            //메모

        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }
        public DateTime EnrollDate { get => enrollDate; set => enrollDate = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int State { get => state; set => state = value; }
        public string Memo { get => memo; set => memo = value; }
    }
}