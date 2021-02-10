using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Automailapp_MrQuang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*  ChromeOptions options = new ChromeOptions();
              options.AddArguments("--disable-extensions"); // to disable extension
              options.AddArguments("--disable-notifications"); // to disable notification
                         driver = new ChromeDriver(options);
              driver.Navigate().GoToUrl("https://facebook.com");
              IWebElement UserTextbox = driver.FindElement(By.Id("email"));
              UserTextbox.SendKeys("broteam168@gmail.com");
              Thread.Sleep(RandomNumber(500, 2000));
              IWebElement PassTextbox = driver.FindElement(By.Id("pass"));
              PassTextbox.SendKeys("broteamson");
              Thread.Sleep(RandomNumber(500, 2000));
              driver.FindElement(By.Name("login")).Click();
              Thread.Sleep(RandomNumber(1000, 5000));
              driver.Navigate().GoToUrl("https://www.facebook.com/groups/262247861337163");

              ScrollToBottom(driver);*/
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UserFb.Text = Automailapp_MrQuang.Properties.Settings.Default.Userfb;
            PassFb.Text = Automailapp_MrQuang.Properties.Settings.Default.Passfb;

            NumberPost.Text = Automailapp_MrQuang.Properties.Settings.Default.NumberPost.ToString();
        }
        private readonly Random _random = new Random();

        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            #region useEngine
            string[] TimeLetterInput = Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistanceLetterInput.Split(' ');
            string[] TimeRestUsPas = Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistanceUsPa.Split(' ');
            string[] TimePasLogin = Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistancePaLogin.Split(' ');

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            ChromeDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://facebook.com");
            #endregion

            LoginFB(driver);

            #region checkinggg
            Thread.Sleep(5000);
            HtmlDocument docMypage = new HtmlDocument();
            docMypage.LoadHtml(driver.PageSource);
            driver.Close();
            driver.Quit();

            var check = (from m in docMypage.DocumentNode.SelectNodes("//div[@class]").Cast<HtmlNode>()
                         where m.Attributes["class"].Value == "m9osqain a5q79mjw jm1wdb64 k4urcfbm"
                         select m).ToList<HtmlNode>();
            if (check.Count != 0)
            {
                MessageBox.Show("Kiểm tra thành công tài khoản có thể đăng nhập");
            }
            else
            {
                MessageBox.Show("Không thể đăng nhập được");
            }
            #endregion

        }
        private void LoginFB(ChromeDriver driver)
        {
            string[] TimeLetterInput = Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistanceLetterInput.Split(' ');
            string[] TimeRestUsPas = Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistanceUsPa.Split(' ');
            string[] TimePasLogin = Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistancePaLogin.Split(' ');

            #region SendkeyUser
            IWebElement UserTextbox = driver.FindElement(By.Id("email"));
            foreach (var item in UserFb.Text.ToCharArray())
            {
                UserTextbox.SendKeys(item.ToString());
                Thread.Sleep(RandomNumber(int.Parse(TimeLetterInput[0]), int.Parse(TimeLetterInput[1])));
            }
            #endregion

            Thread.Sleep(RandomNumber(int.Parse(TimeRestUsPas[0]), int.Parse(TimeRestUsPas[1])));// resting

            #region SendkeyPass
            IWebElement PassTextbox = driver.FindElement(By.Id("pass"));
            foreach (var item in PassFb.Text.ToCharArray())
            {
                PassTextbox.SendKeys(item.ToString());
                Thread.Sleep(RandomNumber(int.Parse(TimeLetterInput[0]), int.Parse(TimeLetterInput[1])));
            }
            #endregion

            #region ClickButtonLogin
            Thread.Sleep(RandomNumber(int.Parse(TimePasLogin[0]), int.Parse(TimePasLogin[1])));
            driver.FindElement(By.Name("login")).Click();
            Thread.Sleep(RandomNumber(int.Parse(TimePasLogin[0]), int.Parse(TimePasLogin[1])));
            #endregion
        }
        private void ButtonSettingLogin_Click(object sender, EventArgs e)
        {
            SettingLogin formSetting = new SettingLogin();
            formSetting.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Automailapp_MrQuang.Properties.Settings.Default.Userfb = UserFb.Text;
            Automailapp_MrQuang.Properties.Settings.Default.Passfb = PassFb.Text;
            Automailapp_MrQuang.Properties.Settings.Default.Save();

        }

        private void RegPostnum_Click(object sender, EventArgs e)
        {
            Automailapp_MrQuang.Properties.Settings.Default.NumberPost = int.Parse(NumberPost.Text);
            Automailapp_MrQuang.Properties.Settings.Default.Save();
            MessageBox.Show("Sửa thành công");
        }
        private void WriteLog(string Message)
        {

        }

        private void Runbutton_Click(object sender, EventArgs e)
        {
            
            string docPath =
             Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            #region useEngine
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions"); // to disable extension
            options.AddArguments("--disable-notifications"); // to disable notification
            ChromeDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://facebook.com");
            #endregion
            try
            {
                LoginFB(driver);
                Thread.Sleep(5000);
            }

            catch (Exception ex) { MessageBox.Show("Lỗi đăng nhập facebook vui lòng kiểm tra lại hoặc liên hệ với nhân viên kỹ thuật.Chi tiết:" + ex.Message); }
            List<GoodUser> listResult = new List<GoodUser>();
            foreach (var link in ListGroup.Text.Split('\n'))
            {


                driver.Navigate().GoToUrl(link);
                for (int i0 = 0; i0 < int.Parse(NumberPost.Text) / 4; i0++)
                {

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    var newScrollHeight = (long)js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight); return document.body.scrollHeight;");
                    Thread.Sleep(10000);
                }
                Thread.Sleep(120000);
                var k = driver.FindElements(By.XPath("//div[@class='oajrlxb2 g5ia77u1 qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 nc684nl6 p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso i1ao9s8h esuyzwwr f1sip0of lzcic4wl oo9gr5id gpro0wi8 lrazzd5p' and @role='button']"));
                foreach (var item in k)
                {
                    try
                    {
                        item.Click();
                        Thread.Sleep(10000);
                    }
                    catch (Exception) { }
                }
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(driver.PageSource);
                Thread.Sleep(5000);

                var Groupfeed = (from m in doc.DocumentNode.SelectNodes("//div[@class]").Cast<HtmlNode>()
                                 where m.Attributes["class"].Value == "du4w35lb k4urcfbm l9j0dhe7 sjgh65i0"
                                 select m).ToList<HtmlNode>();
                foreach (HtmlNode FeedItem in Groupfeed)
                {
                    List<string> keyOK = new List<string>();
                    List<string> email = new List<string>();
                    foreach (var item in Keybox.Text.Split('\n'))
                    {
                        if (FeedItem.InnerText.ToLower().Contains(item.ToLower()))
                        {
                            keyOK.Add(item);
                        }

                    }
                    if (keyOK.Count > 0)
                    {
                        Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
                        RegexOptions.IgnoreCase);
                        //find items that matches with our pattern
                        MatchCollection emailMatches = emailRegex.Matches(FeedItem.InnerHtml);

                        StringBuilder sb = new StringBuilder();

                        foreach (Match emailMatch in emailMatches)
                        {
                            email.Add(emailMatch.Value);
                        }
                        if (email.Count > 0)
                        {



                            try
                            {
                                MailMessage mail = new MailMessage();
                                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                                mail.From = new MailAddress(Usermail.Text);
                                mail.To.Add(email.FirstOrDefault());
                                mail.Subject = "JD Asia || Portfolio & Hồ sơ năng lực";
                                mail.IsBodyHtml = true;
                                string bODY = textBox1.Text;
                                foreach (var item in keyOK)
                                {
                                    bODY += System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\" + item + "\\" + item + ".txt");
                                }
                                bODY += textBox2.Text;
                                mail.Body = bODY;
                                foreach (var item in keyOK)
                                {
                                    var a = Directory.GetFiles(Environment.CurrentDirectory + "\\"+item + "\\Attach");
                                    foreach (var item2 in a)
                                    {
                                        Attachment attachment = new Attachment(item2);
                                        mail.Attachments.Add(attachment);
                                    }
                                }
                                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network; ;
                                SmtpServer.Port = 587;
                                SmtpServer.UseDefaultCredentials = false;
                                SmtpServer.Credentials = new System.Net.NetworkCredential(Usermail.Text, PassMail.Text);
                                SmtpServer.EnableSsl = true;
                                SmtpServer.Send(mail);
                                Thread.Sleep(20000);
                                driver.Navigate().GoToUrl(FeedItem.SelectNodes(".//a[@class='oajrlxb2 g5ia77u1 qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 nc684nl6 p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso i1ao9s8h esuyzwwr f1sip0of lzcic4wl oo9gr5id gpro0wi8 lrazzd5p']").FirstOrDefault().Attributes["href"].Value.Split('/')[4]);
                                Thread.Sleep(5000);
                                IWebElement textbox = driver.FindElement(By.CssSelector("div[class='notranslate _5rpu'][role='textbox']"));
                                textbox.SendKeys("Chào " + FeedItem.SelectNodes(".//a[@class='oajrlxb2 g5ia77u1 qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 nc684nl6 p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso i1ao9s8h esuyzwwr f1sip0of lzcic4wl oo9gr5id gpro0wi8 lrazzd5p']").FirstOrDefault().InnerText + ", mình là Quang, BD của JD Asia. Mình thấy bạn có nhu cầu về ");
                                foreach (var item in keyOK)
                                {
                                    textbox.SendKeys(item.ToString() + ", ");
                                }
                                textbox.SendKeys("nên mình liên hệ ạ.");
                                textbox.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Enter); textbox.SendKeys("Mình đã gửi các thông tin bạn cần qua email [Mail khách hàng], bạn nhớ check mail và phản hồi giúp mình nhé.");

                                textbox.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Enter);
                                textbox.SendKeys("Bạn có thể xem qua portfolio của mình tại website: jdasia.vn");
                                textbox.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Enter);
                                textbox.SendKeys("Cảm ơn " + FeedItem.SelectNodes(".//a[@class='oajrlxb2 g5ia77u1 qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 nc684nl6 p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso i1ao9s8h esuyzwwr f1sip0of lzcic4wl oo9gr5id gpro0wi8 lrazzd5p']").FirstOrDefault().InnerText + ", mình rất mong có cơ hội được hợp tác cùng bạn.");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }


                        }
                        else
                        {
                            try
                            {
                                driver.Navigate().GoToUrl("https://www.facebook.com/messages/t/" + FeedItem.SelectNodes(".//a[@class='oajrlxb2 g5ia77u1 qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 nc684nl6 p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso i1ao9s8h esuyzwwr f1sip0of lzcic4wl oo9gr5id gpro0wi8 lrazzd5p']").FirstOrDefault().Attributes["href"].Value.Split('/')[4]);
                                Thread.Sleep(5000);
                                IWebElement textbox = driver.FindElement(By.CssSelector("div[class='notranslate _5rpu'][role='textbox']"));
                                textbox.SendKeys("Chào " + FeedItem.SelectNodes(".//a[@class='oajrlxb2 g5ia77u1 qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 nc684nl6 p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso i1ao9s8h esuyzwwr f1sip0of lzcic4wl oo9gr5id gpro0wi8 lrazzd5p']").FirstOrDefault().InnerText + ", mình là Quang, BD của JD Asia. Mình thấy bạn có nhu cầu về ");
                                foreach (var item in keyOK)
                                {
                                    textbox.SendKeys(item.ToString() + ", ");
                                }
                                textbox.SendKeys("nên mình liên hệ ạ.");
                                textbox.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Enter);
                                textbox.SendKeys("Bạn có thể xem qua portfolio của mình tại website: jdasia.vn");
                                textbox.SendKeys(OpenQA.Selenium.Keys.Shift + OpenQA.Selenium.Keys.Enter);
                                textbox.SendKeys("Nếu thấy phù hợp, bạn vui lòng cho mình xin email để mình gửi Hồ sơ năng lực và brief form nhé.");
                                textbox.SendKeys(OpenQA.Selenium.Keys.Enter);
                            }
                            catch (Exception) { }
                        }
                        try
                        {
                            Console.WriteLine(FeedItem.SelectNodes(".//a[@class='oajrlxb2 g5ia77u1 qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 nc684nl6 p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso i1ao9s8h esuyzwwr f1sip0of lzcic4wl oo9gr5id gpro0wi8 lrazzd5p']").FirstOrDefault().Attributes["href"].Value + "ok");
                        }
                        catch (Exception) { }
                    }
                }
            }
            driver.Close();
            driver.Quit();
        }
        
        public class GoodUser
        {
            
            public string NameUser { get; set; }
            public string Linknick { get; set; }
            public string NickMessage { get; set; }
            public string NickGmail { get; set; }
            public int GmailorMess { get; set; }
            public DateTime Time { get; set; }
            public List<string> keyword { get; set; }

        }

    }
}

