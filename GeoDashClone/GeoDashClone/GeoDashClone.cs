using System.Drawing;

#pragma warning disable IDE0003
namespace GeoDashClone {
    public partial class GeoDashClone : Form {
        public GeoDashClone() {
            this.InitializeComponent();
        }

        private void GeoDashClone_Load(object sender, EventArgs e) {
            //Hide the form's border
            this.FormBorderStyle = FormBorderStyle.None;
            //Making the form Full Screen
            this.WindowState = FormWindowState.Maximized;

            //Hiding Tab Control Headers
            this.TCMenus.Appearance = TabAppearance.FlatButtons;
            this.TCMenus.ItemSize = new Size(0, 1);
            this.TCMenus.SizeMode = TabSizeMode.Fixed;
            //Position The 'Play' Button
            this.PlayButton.Location = new Point(
                this.Width / 2 - (this.PlayButton.Width / 2),
                this.Height / 2 - this.PlayButton.Height
            );
            //Put exit in top left
            this.MMExitButton.Location = new Point(5, 5);
            //Put Back Button in top left
            this.LevelsBack.Location = new Point(5, 5);
            //Align Level Buttons
            //Previous Level Button
            this.PrevLevel.Location = new Point(
                20,
                this.Height / 2
            );
            //Next Level
            this.NextLevel.Location = new Point(
                this.Width - 60,
                this.Height / 2
            );

        }

        private void MMExitButton_Click(object sender, EventArgs e) {
            //Close the Form with this button
            this.Close();
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            //Changes the active Page
            this.TCMenus.SelectedIndex = this.TCMenus.TabPages.IndexOf(TPLevels);
        }

        private void LevelsBack_Click(object sender, EventArgs e) {
            //Go back to Main Menu
            this.TCMenus.SelectedIndex = this.TCMenus.TabPages.IndexOf(TPMain);
        }
    }
}