using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Appeal
{
    /// <summary>
    /// Логика взаимодействия для btnChanelControl.xaml
    /// </summary>
    public partial class btnChanelControl : UserControl
    {
        #region Property
        public string ChanelName { get => tbChanelName.Text; set => tbChanelName.Text = value; }
        public Image ChanelImage { get => imgChanel; set => imgChanel = value; }
        public string UserSendMessage { get => tbChanelUserSendMassege.Text; set => tbChanelUserSendMassege.Text = value; }
        public string LastMessage { get => tbChanelLastMessage.Text; set => tbChanelLastMessage.Text = value; }
        public string TimeMessage { get => tbChanelData.Text; set => tbChanelData.Text = value; }
        public int CountUnreadMessage { get => Convert.ToInt32(tbCountMessage.Text); set => tbCountMessage.Text = value.ToString(); }
        #endregion

        public btnChanelControl()
        {
            InitializeComponent();
        }
    }
}
