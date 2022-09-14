using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookApp.Logic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormBirtdayCard : Form
    {
        private readonly FacadeManager r_FacadeManager;
        private User m_ChosenFriend;

        public FormBirtdayCard(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
        }

        private void fetchFriendsBirthday()
        {
            const string k_Message = @"None of your friends have their birthday today:( 
In the meantime you can add more cards";
            const string k_Caption = "No Friends For Today";
            List<User> BDFriends;

            try
            {
                BDFriends = r_FacadeManager.FindAllFriendsWithTodayBDay();
                if (BDFriends.Count > 0)
                {
                    foreach (User friend in BDFriends)
                    {
                        listBoxBDFriends.Items.Add(friend);
                    }

                    listBoxBDFriends.Visible = true;
                }
                else
                {
                    MessageBox.Show(k_Message, k_Caption);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchBirthdayCard()
        {
            RichTextBox cardBox;
            List<string> cards = r_FacadeManager.BDCards;
            flowLayoutPanelBDCards.AutoScroll = true;
            flowLayoutPanelBDCards.Controls.Clear();

            if (cards != null)
            {
                foreach (string card in cards)
                {
                    cardBox = new RichTextBox { Text = card };
                    disableChosenCard(cardBox);
                    cardBox.ReadOnly = true;
                    cardBox.Visible = true;
                    cardBox.Click += cardBox_Click;
                    flowLayoutPanelBDCards.Controls.Add(cardBox);
                }
            }
        }

        private void disableChosenCard(RichTextBox i_BDCard)
        {
            i_BDCard.BackColor = Color.White;
            i_BDCard.ForeColor = Color.Black;
        }

        private void activateChosenCard(RichTextBox i_BDCard)
        {
            i_BDCard.BackColor = Color.DarkBlue;
            i_BDCard.ForeColor = Color.White;
        }

        private void cardBox_Click(object sender, EventArgs e)
        {
            const string k_Message = "Do you want to post the selected birthday card to your chosen friend?";
            const string k_Caption = "Posting card!";
            const string k_CaptionError = "Facebook Error!";
            DialogResult result;
            RichTextBox chosenCard = sender as RichTextBox;

            if (m_ChosenFriend != null)
            {
                activateChosenCard(chosenCard);
                
                result = MessageBox.Show(k_Message, k_Caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                try
                {
                    if (result == DialogResult.Yes)
                    {
                        r_FacadeManager.PostBDCard(m_ChosenFriend, (sender as RichTextBox).Text);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString(), k_CaptionError);
                }
            }

            disableChosenCard(chosenCard);
        }

        private void buttonAddBDCard_Click(object sender, EventArgs e)
        {
            string bdCard = richTextBoxBDCard.Text;

            r_FacadeManager.AddCardToSavedCards(bdCard);
            fetchBirthdayCard();
        }

        private void listBoxBDFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string k_Message = "Great! Please choose card...";
            const string k_Caption = "Friend chosen!";
            DialogResult result = MessageBox.Show(k_Message, k_Caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                flowLayoutPanelBDCards.Focus();
                m_ChosenFriend = listBoxBDFriends.SelectedItem as User;
            }
        }

        private void FormBirtdayCard_Load(object sender, EventArgs e)
        {
            fetchFriendsBirthday();
        }

        private void richTextBoxBDCard_Click(object sender, EventArgs e)
        {
            richTextBoxBDCard.Text = "";
            richTextBoxBDCard.ReadOnly = false;
            richTextBoxBDCard.ForeColor = Color.Black;
        }
    }
}
