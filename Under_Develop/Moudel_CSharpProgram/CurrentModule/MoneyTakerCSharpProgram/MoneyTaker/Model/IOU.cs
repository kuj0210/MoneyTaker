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

        internal string Name
        {
            get { return name; }
            set { name = value; }
        }

        internal int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        internal DateTime EnrollDate
        {
            get { return enrollDate; }
            set { enrollDate = value; }
        }

        internal DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        internal DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        internal int State
        {
            get { return state; }
            set { state = value; }
        }

        internal string Memo
        {
            get { return memo; }
            set { memo = value; }
        }
    }
}