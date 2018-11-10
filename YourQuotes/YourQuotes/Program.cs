using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
namespace YourQuotes
{
    class Program
    {

        public static void Main(string[] args)
        {
            Program.Contact();
        }

        
        public static void Contact()//EmailFormModel model)
        {
            
            var QuoteReader = new StreamReader(@"C:\Users\kumasuje\Downloads\Quotes.txt",Encoding.UTF8);
            List<string> QuotesList = new List<string>();
            
            //QuoteReader.Read();
            //QuoteReader.DiscardBufferedData();
            var Quote = QuoteReader.ReadToEnd();
            var singleQuotesList = Quote.Split(';');
            singleQuotesList[1] = Regex.Replace(singleQuotesList[1], @"[\r\n]", "");
            for (int i = 0; i < singleQuotesList.Length; i++)
            {
                QuotesList.Add(singleQuotesList[i]);
            }
            QuoteReader.Dispose();
            QuoteReader.Close();
            



            string path = @"C:\Users\kumasuje\Downloads\Quotes.txt";
            StreamWriter sw = File.CreateText(path);
            
            
            for (int i = 1; i < singleQuotesList.Length; i++)
            {
                sw.Write(singleQuotesList[i]);
                sw.Write(';');
            }
            sw.WriteLine();
            sw.Write(singleQuotesList[0]);
            sw.Flush();
            sw.Dispose();
            sw.Close();

            //Read Email List

            var reader = new StreamReader(@"C:\Users\kumasuje\Downloads\EmailList.txt", Encoding.UTF8);
            var line = reader.ReadToEnd();
            var values = line.Split('\n');

            var message = new MailMessage();
            for (int i = 0; i < values.Length; i++)
            {
                var val = values[i].Split('\r');
                message.To.Add(new MailAddress(val[0]).ToString());// replace with valid value 
            }

            message.From = new MailAddress("Sujeet.Kumar03@mphasis.com");  // replace with valid value
            message.Subject = "Mphasis Boral Quotes";//Your email subject

            message.IsBodyHtml = true;

            //LinkedResource img = new LinkedResource("1.jpg", MediaTypeNames.Image.Jpeg);
            //img.ContentId = Guid.NewGuid().ToString();


            #region //body test1
            //message.Body = string.Format(@"<table><tr><td width='635' height='360' background=""cid:{0}""><center>This cell has a background attribute.</center></td></tr></table>", img.ContentId);
            #endregion

            #region //body test2
            //message.Body = string.Format("<table border=1>" +
            //                                             "<tr>" +
            //                                                    "<td></td>" +
            //                                                    "<td rowspan=2><img src='1.PNG' alt='Mphasis' width='100%'></td>" +
            //                                             "</tr>" +
            //                                             "<tr>" +
            //                                                    "<td colspan=2><h1><center> Hello Everyone </center></h1></td>" +
            //                                             "</tr>" +
            //                             "</table>");

            #endregion
            
            #region// working body

            message.Body = string.Format("<table width='100 %' border='0' cellspacing='0' cellpadding='0'>" +
                                            "<tbody>" +
                                            "<tr>" +
                                                "<td background='1.jpg' width='600' height='300' valign='top' class='bgresize'>" +
                                                    "<!--[if gte mso 9]>" +
                                                        "<v:rect xmlns:v='urn:schemas-microsoft-com:vml' fill='true' stroke='false' style='width:600px;height:300px;'>" +
                                                        "<v:fill type='tile' src= 'C:\\Users\\kumasuje\\Desktop\\Current\\1.PNG'/>" +
                                                        "<v:textbox inset = '0,0,0,0'>" +
                                                    "<![endif]-- >" +
                                            "<div>" +
                                            "<table width='100%' border='0' cellspacing='0' cellpadding='0'>" +
                                                "<tbody>" +
                                                    "<tr>" +
                                                      "<td width='30' align='left' valign='top' style='font-size:0%;' class='mobile-hidden'><img src='C:\\Users\\kumasuje\\Desktop\\Current\\1.PNG' width='30' height='1' style='display:block;' border='0'/></td>" +
                                                      "<td align='left' valign='top' class='mobile-padding'>" +
                                            "<table width='100%' border='0' cellspacing='0' cellpadding='0'>" +
                                                "<tbody>" +
                                                    "<tr>" +
                                                        "<td align='left' valign='top' style='padding-top:140px;' class='padding65'><span><center><h3><font face='Comic Sans MS' color='yellow'>" + singleQuotesList[0] + "</font></h3></center></span></td>" +
                                                    "</tr>" +
                                                "</tbody>" +
                                            "</table>" +
                                            "</td>" +
                                            "<td width='30' align='left' valign='top' class='mobile-hidden' style='font-size:0%;'><img src='C:\\Users\\kumasuje\\Desktop\\Current\\1.PNG' width='30' height='1' style='display: block;' border='0'/></td>" +
                                        "</tr>" +
                                        "</tbody>" +
                                        "</table>" +
                                        "</div>" +

                                        "<!--[if gte mso 9]>" +
                                        "</v:textbox>" +
                                        "</v:rect>" +
                                        "<![endif]-->" +

                                        "</td>" +
                                        "</tr>" +
                                        "</tbody>" +
                                        "</table>");

            #endregion

            Attachment img = new Attachment(@"C:\Users\kumasuje\Desktop\Current\1.PNG");
            message.Attachments.Add(img);


            #region //body format test

            //message.Body = string.Format("<td valign='top' height='700' background='https://preview.ibb.co/iqA1hp/1.png' bgcolor='#f7901e' style='height:700px; background-image:url(https://preview.ibb.co/iqA1hp/1.png);background-color:#f7901e;'>" +
            //                              "<!--[if gte mso 9]>" +

            //                              "<v:image xmlns:v='urn:schemas-microsoft-com:vml' fill='true' stroke='false' style=' border:0;display:inline-block; width:550px; height:700px;' src='https://preview.ibb.co/iqA1hp/1.png'/>" +

            //"<v:rect xmlns:v='urn:schemas-microsoft-com:vml' fill='true' stroke = 'false' style=' border:0;display: inline-block;position: absolute; width: 550px; height: 700px;' >" +

            //         "<v:fill opacity='0%' color='#f7901e'/>" +

            //           "<v:textbox inset='0,0,0,0'>" +

            //              "<![endif]-->" +

            //            "<div>" +

            //                "<h3><center>Hello guys</center></h3>" +

            //            "</div>" +

            //              "<!--[if gte mso 9]>" +

            //             "</v:textbox>" +

            //              "</v:fill>" +

            //             "</v:rect>" +

            //              "</v:image>" +

            //               "<![endif]-- >" +
            //             "</td> ");

            #endregion


            #region //save email locally

            //var client = new SmtpClient("localhost");

            //client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
            //client.PickupDirectoryLocation = @"C:\Users\kumasuje\source\repos\YourQuotes\YourQuotes\Resource";
            //client.Send(message);

            #endregion

            try
            {
                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "Sujeet.Kumar03@mphasis.com",  // replace with valid value
                        #region  //password-- pls don't open
                        Password = "ruby@9001"  // replace with valid value
                        #endregion
                    };
                    smtp.EnableSsl = true;
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    //smtp.UseDefaultCredentials = false;
                    smtp.Timeout = 2000000;
                    smtp.Send(message);
                    Console.WriteLine("success");
                    //Console.ReadLine();
                }
            }
            catch (Exception pEx)
            {
                throw pEx;
            }
        }
    }
}

