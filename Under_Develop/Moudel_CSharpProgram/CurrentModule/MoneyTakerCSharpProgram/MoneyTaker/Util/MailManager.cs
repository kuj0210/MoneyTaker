using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace MoneyTaker
{
    public class MailManager
    {
        private static readonly MailAddress FROM = new MailAddress("noreply@alcoholcoding.com", "Alcoholcoding Team.", System.Text.Encoding.UTF8);

        public static bool SendCode(String receiver, String Code)
        {
            String title = Propertise.APPNAME + " 회원가입 인증코드입니다.";
            String body = "<HTML>" +
                "반갑습니다." +
                "<BR>" +
                Propertise.APPNAME + " 의 가입을 위한 인증코드 안내 메일입니다." +
                "<BR>" +
                "<BR>" +
                "<H2>인증코드 : <STRONG>" + Code + "</STRONG></H2>" +
                "<BR>" +
                "<BR>" +
                "이 메일을 요청 한 적이 없다면 무시해주세요." +
                "<BR>" +
                "Alcoholcoding Team 드림." +
                "</HTML>";

            Send(receiver, title, body);
            return true;
        }

        /// <summary>
        /// SMTP 프로토콜을 이용하여 메일을 전송하는 메서드입니다.
        /// since : 2017-12-21
        /// autor : 서정삼 
        /// </summary>
        /// <param name="receiver"></param>
        /// <returns></returns>
        public static bool Send(String receiver, String title, String body)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false; // 시스템에 설정된 인증 정보를 사용하지 않는다.
            client.EnableSsl = true;  // SSL을 사용한다.
            client.DeliveryMethod = SmtpDeliveryMethod.Network; // 이걸 하지 않으면 Gmail에 인증을 받지 못한다.
            client.Credentials = new System.Net.NetworkCredential(SMTPConfig.ID, SMTPConfig.PASSWORD);

            MailAddress to = new MailAddress(receiver);

            MailMessage message = new MailMessage();
            message.From = FROM;
            message.To.Add(to);
            message.SubjectEncoding = System.Text.Encoding.UTF8;  //메일 제목의 Encoding을 UTF8로 설정
            message.BodyEncoding = System.Text.Encoding.UTF8;     //메일 내용의 Encoding을 UTF8로 설정
            message.IsBodyHtml = true;
            message.Subject = title;
            message.Body = body;

            try
            {
                // 동기로 메일을 보낸다.
                client.Send(message);

                // Clean up.
                message.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

    }
}