using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace MoneyTaker
{
    public class Model
    {

        List<Friend> friends = new List<Friend>();
        List<Borrow> borrowData = new List<Borrow>();
        List<Buscar> buscarData = new List<Buscar>();

        public Model()
        {
            //Save();
            Load();
        }

        public Model(List<Friend> friends, List<Borrow> borrowData, List<Buscar> buscarData)
        {
            this.friends = friends;
            this.borrowData = borrowData;
            this.buscarData = buscarData;
        }

        internal List<Friend> Friends { get => friends; set => friends = value; }
        internal List<Borrow> BorrowData { get => borrowData; set => borrowData = value; }
        internal List<Buscar> BuscarData { get => buscarData; set => buscarData = value; }


        /** 아래로 파일 저장 파트 **/
        public void Load()
        {
            try
            {
                friends.Clear();
                borrowData.Clear();
                buscarData.Clear();

                XmlDocument xml = new XmlDocument();
                xml.Load(Propertise.MODEL_PATH);

                XmlNodeList root1 = xml.SelectNodes("/Models/Borrow/Item");
                XmlNodeList root2 = xml.SelectNodes("/Models/Buscar/Item");
                XmlNodeList root3 = xml.SelectNodes("/Models/Friend/Item");

                foreach (XmlNode item in root1)
                {
                    borrowData.Add(new Borrow(item.Attributes["name"].Value,
                        Int32.Parse(item.Attributes["money"].Value),
                        Convert.ToDateTime(item.Attributes["startdate"].Value),
                        Convert.ToDateTime(item.Attributes["enddate"].Value),
                        item.Attributes["memo"].Value));
                }
                foreach (XmlNode item in root2)
                {
                    buscarData.Add(new Buscar(item.Attributes["name"].Value,
                        Int32.Parse(item.Attributes["money"].Value),
                        Convert.ToDateTime(item.Attributes["startdate"].Value),
                        Convert.ToDateTime(item.Attributes["enddate"].Value),
                        item.Attributes["memo"].Value));
                }
                foreach (XmlNode item in root3)
                {
                    friends.Add(new Friend(item.Attributes["name"].Value,
                        item.Attributes["email"].Value,
                        item.Attributes["group"].Value,
                        Int32.Parse(item.Attributes["credibility"].Value),
                        item.Attributes["uguid"].Value,
                        item.Attributes["gguid"].Value,
                        Int32.Parse(item.Attributes["tag"].Value)));
                }
            }
            catch (Exception e)
            {
                // ignore
                // 파일이 존재하지않는경우 프로그램 최초시작에 Exception 발생 가능
                // 추후 상황에 따른 Exception 처리 필요
                // TODO : 추후 상황에 따른 Exception 처리 필요, 20180113 서정삼
            }
        }

        public void Save()
        {

            XmlDocument xml = new XmlDocument();
            XmlNode root = xml.CreateElement("Models");
            xml.AppendChild(root);
            XmlNode buscarRoot = xml.CreateElement("Buscar");
            foreach (Buscar item in BuscarData)
            {
                XmlNode buscarItem = xml.CreateElement("Item");

                XmlAttribute name = xml.CreateAttribute("name");
                name.Value = item.Name;
                buscarItem.Attributes.Append(name);

                XmlAttribute price = xml.CreateAttribute("money");
                price.Value = item.Money.ToString();
                buscarItem.Attributes.Append(price);

                XmlAttribute startdate = xml.CreateAttribute("startdate");
                startdate.Value = item.Startdate.ToString();
                buscarItem.Attributes.Append(startdate);

                XmlAttribute enddate = xml.CreateAttribute("enddate");
                enddate.Value = item.Enddate.ToString();
                buscarItem.Attributes.Append(enddate);

                XmlAttribute memo = xml.CreateAttribute("memo");
                memo.Value = item.Memo;
                buscarItem.Attributes.Append(memo);

                buscarRoot.AppendChild(buscarItem);
            }
            root.AppendChild(buscarRoot);

            XmlNode borrowRoot = xml.CreateElement("Borrow");
            foreach (Borrow item in BorrowData)
            {
                XmlNode borrowItem = xml.CreateElement("Item");

                XmlAttribute name = xml.CreateAttribute("name");
                name.Value = item.Name;
                borrowItem.Attributes.Append(name);

                XmlAttribute price = xml.CreateAttribute("money");
                price.Value = item.Money.ToString();
                borrowItem.Attributes.Append(price);

                XmlAttribute startdate = xml.CreateAttribute("startdate");
                startdate.Value = item.Startdate.ToString();
                borrowItem.Attributes.Append(startdate);

                XmlAttribute enddate = xml.CreateAttribute("enddate");
                enddate.Value = item.Enddate.ToString();
                borrowItem.Attributes.Append(enddate);

                XmlAttribute memo = xml.CreateAttribute("memo");
                memo.Value = item.Memo;
                borrowItem.Attributes.Append(memo);

                borrowRoot.AppendChild(borrowItem);
            }
            root.AppendChild(borrowRoot);


            XmlNode friendsRoot = xml.CreateElement("Friend");
            foreach (Friend item in Friends)
            {
                XmlNode friendsItem = xml.CreateElement("Item");

                XmlAttribute group = xml.CreateAttribute("group");
                group.Value = item.Group;
                friendsItem.Attributes.Append(group);

                XmlAttribute name = xml.CreateAttribute("name");
                name.Value = item.Name;
                friendsItem.Attributes.Append(name);

                XmlAttribute email = xml.CreateAttribute("email");
                email.Value = item.Email;
                friendsItem.Attributes.Append(email);

                XmlAttribute credibility = xml.CreateAttribute("credibility");
                credibility.Value = item.Credibility.ToString();
                friendsItem.Attributes.Append(credibility);

                XmlAttribute uguid = xml.CreateAttribute("uguid");
                uguid.Value = item.Uguid;
                friendsItem.Attributes.Append(uguid);

                XmlAttribute gguid = xml.CreateAttribute("gguid");
                gguid.Value = item.Gguid;
                friendsItem.Attributes.Append(gguid);

                XmlAttribute tag = xml.CreateAttribute("tag");
                tag.Value = item.Tag.ToString();
                friendsItem.Attributes.Append(tag);

                friendsRoot.AppendChild(friendsItem);
            }
            root.AppendChild(friendsRoot);

            xml.Save(Propertise.MODEL_PATH);

        }


    }
}