using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Net.Imap;
using System.Net;
using MimeKit.Text;
using MailKit.Security;


namespace WinFormsAppEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("nijegorodov@miac.nnov.ru"));
            email.To.Add(MailboxAddress.Parse("nijegorodov@miac.nnov.ru"));
            email.Subject = "Test Email Subject 111";
            email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };
            //email.Body = new TextPart(TextFormat.Text) { Text = "сообщение для теста" };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.server.ru", 587);
            smtp.Authenticate("login", "password");
            smtp.Send(email);
            smtp.Disconnect(true);


        }

        


    }

    


}
