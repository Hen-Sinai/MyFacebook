using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace BasicFacebookFeatures
{
    public partial class FormEvents : Form
    {
        private readonly FacadeManager r_FacadeManager;
        private enum eTimeType
        {
            Date,
            Hour
        }

        public FormEvents(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
        }

        private void FormEvents_Load(object sender, EventArgs e)
        {
            fetchUserNotRepliedEvents();
        }

        private void fetchUserNotRepliedEvents()
        {
            try
            {
                foreach (Event currentEvent in r_FacadeManager.LoggedInUser.EventsNotYetReplied)
                {
                    listBoxEvents.Items.Add(currentEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string k_Caption = "Facebook Error fetching event.";
            Event senderEvent;
            string event_Time, eventLocation, eventDate, eventHour;
            string[] timeParts, locateParts;

            try
            {
                senderEvent = listBoxEvents.SelectedItem as Event;

                if (senderEvent != null)
                {
                    if (senderEvent.Cover.SourceURL != null)
                    {
                        pictureBoxEvent.LoadAsync(senderEvent.Cover.SourceURL);
                        pictureBoxEvent.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    event_Time = senderEvent.TimeString;
                    timeParts = event_Time.Split(' ');
                    eventDate = timeParts[(int)eTimeType.Date];
                    eventHour = timeParts[(int)eTimeType.Hour];
                    labelDate.Top = pictureBoxEvent.Bottom - 1;
                    labelDate.Left = listBoxEvents.Right + 5;
                    labelDate.Text = "DATE and TIME: " + eventDate + " at " + eventHour;
                    labelLocation.Top = labelDate.Bottom - 1;
                    labelLocation.Left = labelDate.Left;
                    locateParts = senderEvent.Location.Split('U');
                    eventLocation = locateParts[0].Replace("Name:", "");
                    labelLocation.Text = "LOCATION: " + eventLocation;
                    buttonAttend.Visible = true;
                    buttonAttend.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, k_Caption);
            }
        }

        private void buttonAttend_Click(object sender, EventArgs e)
        {
            const string message = "Are you really going to attend this event?";
            const string caption = "Attending!";
            DialogResult result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                (sender as Event).Respond(Event.eRsvpType.Attending);
            }
        }
    }
}