using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace GameTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SectionItems1.Visibility = Visibility.Hidden;
            SectionItems2.Visibility = Visibility.Hidden;
            SectionItems3.Visibility = Visibility.Hidden;
            SectionItems4.Visibility = Visibility.Hidden;
            SectionItems5.Visibility = Visibility.Hidden;
            SectionItems6.Visibility = Visibility.Hidden;
            SectionItems7.Visibility = Visibility.Hidden;
            SectionItems8.Visibility = Visibility.Hidden;
            SectionItems9.Visibility = Visibility.Hidden;
            SectionItems10.Visibility = Visibility.Hidden;
            Armor.Visibility = Visibility.Hidden;
            Weapons.Visibility = Visibility.Hidden;
            Bosses.Visibility = Visibility.Hidden;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Armor.Visibility = Visibility.Visible;
            Weapons.Visibility = Visibility.Visible;
            Bosses.Visibility = Visibility.Visible;
            SectionItems1.Visibility = Visibility.Hidden;
            SectionItems2.Visibility = Visibility.Hidden;
            SectionItems3.Visibility = Visibility.Hidden;
            SectionItems4.Visibility = Visibility.Hidden;
            SectionItems5.Visibility = Visibility.Hidden;
            SectionItems6.Visibility = Visibility.Hidden;
            SectionItems7.Visibility = Visibility.Hidden;
            SectionItems8.Visibility = Visibility.Hidden;
            SectionItems9.Visibility = Visibility.Hidden;
            SectionItems10.Visibility = Visibility.Hidden;
            if (sender.GetHashCode() == Dark_Souls_Remastered.GetHashCode())
            {
                GameName.Text = "Dark Souls Remastered";
            }
            else if (sender.GetHashCode() == Dark_Souls_2.GetHashCode())
            {
                GameName.Text = "Dark Souls 2";
            }
            else if (sender.GetHashCode() == Dark_Souls_3.GetHashCode())
            {
                GameName.Text = "Dark Souls 3";
            }
            else if (sender.GetHashCode() == Bloodborne.GetHashCode())
            {
                GameName.Text = "Bloodborne";
            }
            else if (sender.GetHashCode() == Sekiro.GetHashCode())
            {
                GameName.Text = "Sekiro";
                Armor.Visibility = Visibility.Hidden;
                Weapons.Visibility = Visibility.Hidden;
            }
            else if (sender.GetHashCode() == Elden_Ring.GetHashCode())
            {
                GameName.Text = "Elden Ring";
            }
            else if (sender.GetHashCode() == Lies_of_P.GetHashCode())
            {
                GameName.Text = "Lies of P";
                Armor.Visibility = Visibility.Hidden;
            }
            else
            {
                GameName.Text = "Fant ikke Navnet";
            }
        }

        private void Section_Click(object sender, RoutedEventArgs e)
        {
            SectionItems1.Visibility = Visibility.Visible;
            SectionItems2.Visibility = Visibility.Visible;
            SectionItems3.Visibility = Visibility.Visible;
            SectionItems4.Visibility = Visibility.Visible;
            SectionItems5.Visibility = Visibility.Visible;
            SectionItems6.Visibility = Visibility.Visible;
            SectionItems7.Visibility = Visibility.Visible;
            SectionItems8.Visibility = Visibility.Visible;
            SectionItems9.Visibility = Visibility.Visible;
            SectionItems10.Visibility = Visibility.Visible;
            if (GameName.Text.GetHashCode() == "Dark Souls Remastered".GetHashCode() && sender.GetHashCode() == Armor.GetHashCode())
            {
                SectionItems1.Content = "Wanderer Hood";
                SectionItems2.Content = "Thief Mask";
                SectionItems3.Content = "Wanderer Coat";
                SectionItems4.Content = "Black Leather Armor";
                SectionItems5.Content = "Wanderer Manchette";
                SectionItems6.Content = "Black Leather Gloves";
                SectionItems7.Content = "Wanderer Boots";
                SectionItems8.Content = "Black Leather Boots";
                SectionItems9.Content = "Fang Boar Helm";
                SectionItems10.Content = "Gargoyle Helm";
            }
            else if (GameName.Text.GetHashCode() == "Dark Souls Remastered".GetHashCode() && sender.GetHashCode() == Weapons.GetHashCode())
            {
                SectionItems1.Content = "Halberd";
                SectionItems2.Content = "Titanite Catch Pole";
                SectionItems3.Content = "Rapier";
                SectionItems4.Content = "Ricard's Rapier";
                SectionItems5.Content = "Manus Catalyst";
                SectionItems6.Content = "Oolacile Ivory Catalyst";
                SectionItems7.Content = "Ghost Blade";
                SectionItems8.Content = "Priscilla's Dagger";
                SectionItems9.Content = "Broadsword";
                SectionItems10.Content = "Silver Knight Straight Sword";
            }
            else if (GameName.Text.GetHashCode() == "Dark Souls Remastered".GetHashCode() && sender.GetHashCode() == Bosses.GetHashCode())
            {
                SectionItems1.Content = "Asylum Demon";
                SectionItems2.Content = "Bell Gargoyle";
                SectionItems3.Content = "Capra Demon";
                SectionItems4.Content = "Ceaseless Discharge";
                SectionItems5.Content = "Centipede Demon";
                SectionItems6.Content = "Chaos Witch Quelaag";
                SectionItems7.Content = "Crossbreed Priscilla";
                SectionItems8.Content = "Dark Sun Gwyndolin";
                SectionItems9.Content = "Demon Firesage";
                SectionItems10.Content = "Four Kings";
            }
            else if (GameName.Text.GetHashCode() == "Dark Souls 2".GetHashCode() && sender.GetHashCode() == Armor.GetHashCode())
            {
                SectionItems1.Content = "Alonne Captain Helm";
                SectionItems2.Content = "Alonne Knight Helm";
                SectionItems3.Content = "Agdayne's Black Robe";
                SectionItems4.Content = "Alonne Captain Armor";
                SectionItems5.Content = "Agdayne's Black Gloves";
                SectionItems6.Content = "Alonne Captain Gauntlets";
                SectionItems7.Content = "Agdayne's Kilt";
                SectionItems8.Content = "Alonne's Leggings";
                SectionItems9.Content = "Barrel";
                SectionItems10.Content = "Durgo's Hat";
            }
            else if (GameName.Text.GetHashCode() == "Dark Souls 2".GetHashCode() && sender.GetHashCode() == Weapons.GetHashCode())
            {
                SectionItems1.Content = "Black Flamestone Dagger";
                SectionItems2.Content = "Umbral Dagger";
                SectionItems3.Content = "Bluemoon Greatsword";
                SectionItems4.Content = "Ruler's Sword";
                SectionItems5.Content = "Smelter Sword";
                SectionItems6.Content = "Crypt Blacksword";
                SectionItems7.Content = "Manikin Sabre";
                SectionItems8.Content = "Eleum Loyce";
                SectionItems9.Content = "Chaos Blade";
                SectionItems10.Content = "Bewitched Alonne Sword";
            }
            else if (GameName.Text.GetHashCode() == "Dark Souls 2".GetHashCode() && sender.GetHashCode() == Bosses.GetHashCode())
            {
                SectionItems1.Content = "The Last Giant";
                SectionItems2.Content = "The Pursuer";
                SectionItems3.Content = "Executioner's Chariot";
                SectionItems4.Content = "Looking Glass Knight";
                SectionItems5.Content = "The Skeleton Lords";
                SectionItems6.Content = "Flexile Sentry";
                SectionItems7.Content = "Lost Sinner";
                SectionItems8.Content = "Belfry Gargoyles";
                SectionItems9.Content = "Ruin Sentinel";
                SectionItems10.Content = "Royal Rat Vanguard";
            }
            else if (GameName.Text.GetHashCode() == "Dark Souls 3".GetHashCode() && sender.GetHashCode() == Armor.GetHashCode())
            {
                SectionItems1.Content = "Standard Helm";
                SectionItems2.Content = "Brigand Hood";
                SectionItems3.Content = "Hard Leather Armor";
                SectionItems4.Content = "Brigand Armor";
                SectionItems5.Content = "Hard Leather Gauntlets";
                SectionItems6.Content = "Brigand Gauntlets";
                SectionItems7.Content = "Hard Leather Boots";
                SectionItems8.Content = "Brigand Trousers";
                SectionItems9.Content = "Follower Helm";
                SectionItems10.Content = "Antiquated Plain Garb";
            }
            else if (GameName.Text.GetHashCode() == "Dark Souls 3".GetHashCode() && sender.GetHashCode() == Weapons.GetHashCode())
            {
                SectionItems1.Content = "Mail Breaker";
                SectionItems2.Content = "Brigand Twindaggers";
                SectionItems3.Content = "Hollowslayer Greatsword";
                SectionItems4.Content = "Black Knight Sword";
                SectionItems5.Content = "Wolnir's Holy Sword";
                SectionItems6.Content = "Moonlight Greatsword";
                SectionItems7.Content = "Astora Greatsword";
                SectionItems8.Content = "Fume Ultra Greatsword";
                SectionItems9.Content = "Scimitar";
                SectionItems10.Content = "Demon's Scar";
            }
            else if (GameName.Text.GetHashCode() == "Dark Souls 3".GetHashCode() && sender.GetHashCode() == Bosses.GetHashCode())
            {
                SectionItems1.Content = "Cemetery of Ash";
                SectionItems2.Content = "High Wall of Lothric";
                SectionItems3.Content = "Undead Settlement";
                SectionItems4.Content = "Road of Sacrifices";
                SectionItems5.Content = "Farron Keep";
                SectionItems6.Content = "Cathedral of the Deep";
                SectionItems7.Content = "Catacombs of Carthus";
                SectionItems8.Content = "Smouldering Lake";
                SectionItems9.Content = "Irithyll of the Boreal Valley";
                SectionItems10.Content = "Profaned Capital";
            }
            else if (GameName.Text.GetHashCode() == "Bloodborne".GetHashCode() && sender.GetHashCode() == Armor.GetHashCode())
            {
                SectionItems1.Content = "Beak Mask";
                SectionItems2.Content = "Black Church Hat";
                SectionItems3.Content = "Ashen Hunter Garb";
                SectionItems4.Content = "Beast Hide Garb";
                SectionItems5.Content = "Ashen Hunter Gloves";
                SectionItems6.Content = "Bloodied Arm Bands";
                SectionItems7.Content = "Arianna's Shoes";
                SectionItems8.Content = "Ashen Hunter Trousers";
                SectionItems9.Visibility = Visibility.Hidden;
                SectionItems10.Visibility = Visibility.Hidden;
            }
            else if (GameName.Text.GetHashCode() == "Bloodborne".GetHashCode() && sender.GetHashCode() == Weapons.GetHashCode())
            {
                SectionItems1.Content = "Amygdalan Arm";
                SectionItems2.Content = "Beast Claw";
                SectionItems3.Content = "Beasthunter Saif";
                SectionItems4.Content = "Beast Cutter";
                SectionItems5.Content = "Blade of Mercy";
                SectionItems6.Content = "Bloodletter";
                SectionItems7.Content = "Boom Hammer";
                SectionItems8.Content = "Burial Blade";
                SectionItems9.Content = "Chikage";
                SectionItems10.Content = "Church Pick";
            }
            else if (GameName.Text.GetHashCode() == "Bloodborne".GetHashCode() && sender.GetHashCode() == Bosses.GetHashCode())
            {
                SectionItems1.Content = "Amygdala";
                SectionItems2.Content = "Blood Starved Beast";
                SectionItems3.Content = "Celestial Emissary";
                SectionItems4.Content = "Cleric Beast";
                SectionItems5.Content = "Darkbeast Paarl";
                SectionItems6.Content = "Ebrietas, Daughter of the Cosmos";
                SectionItems7.Content = "Father Gascoigne";
                SectionItems8.Content = "Gehrman, The First Hunter";
                SectionItems9.Content = "Martyr Logarius";
                SectionItems10.Content = "Mergo's Wet Nurse";
            }
            else if (GameName.Text.GetHashCode() == "Sekiro".GetHashCode() && sender.GetHashCode() == Bosses.GetHashCode())
            {
                SectionItems1.Content = "Gyoubu Masataka Oniwa";
                SectionItems2.Content = "Lady Butterfly";
                SectionItems3.Content = "Genichiro Ashina";
                SectionItems4.Content = "Folding Screen Monkeys";
                SectionItems5.Content = "Guardian Ape";
                SectionItems6.Content = "Headless Ape";
                SectionItems7.Content = "Corrupted Monk";
                SectionItems8.Content = "Isshin Ashina";
                SectionItems9.Content = "Great Shinobi Owl";
                SectionItems10.Content = "True Corrupted Monk";
            }
            else if (GameName.Text.GetHashCode() == "Elden Ring".GetHashCode() && sender.GetHashCode() == Armor.GetHashCode())
            {
                SectionItems1.Content = "Alberich's Pointed Hat";
                SectionItems2.Content = "Albinauric Mask";
                SectionItems3.Content = "All-Knowing Armor";
                SectionItems4.Content = "alberichs robe";
                SectionItems5.Content = "Alberich's Bracers";
                SectionItems6.Content = "All-Knowing Gauntlets";
                SectionItems7.Content = "All-Knowing Greaves";
                SectionItems8.Content = "Alberich's Trousers";
                SectionItems9.Visibility = Visibility.Hidden;
                SectionItems10.Visibility = Visibility.Hidden;
            }
            else if (GameName.Text.GetHashCode() == "Elden Ring".GetHashCode() && sender.GetHashCode() == Weapons.GetHashCode())
            {
                SectionItems1.Content = "misericorde";
                SectionItems2.Content = "Crystal Knife";
                SectionItems3.Content = "Crystal Sword";
                SectionItems4.Content = "Sword of Night and Flame";
                SectionItems5.Content = "Alabaster Lord's Sword";
                SectionItems6.Content = "Dark Moon Greatsword";
                SectionItems7.Content = "Watchdog's Greatsword";
                SectionItems8.Content = "Ruins Greatsword";
                SectionItems9.Content = "Bloody Helice";
                SectionItems10.Content = "Dragon King's Cragblade";
            }
            else if (GameName.Text.GetHashCode() == "Elden Ring".GetHashCode() && sender.GetHashCode() == Bosses.GetHashCode())
            {
                SectionItems1.Content = "Margit, the Fell Omen";
                SectionItems2.Content = "Godrick the Grafted";
                SectionItems3.Content = "Red Wolf of Radagon";
                SectionItems4.Content = "Rennala, Queen of the Full Moon";
                SectionItems5.Content = "Abductor Virgins";
                SectionItems6.Content = "Godskin Noble";
                SectionItems7.Content = "Rykard, Lord of Blasphemy";
                SectionItems8.Content = "Godfrey, First Elden Lord";
                SectionItems9.Content = "Morgott, the Omen King";
                SectionItems10.Content = "Godskin Duo";
            }
            else if (GameName.Text.GetHashCode() == "Lies of P".GetHashCode() && sender.GetHashCode() == Weapons.GetHashCode())
            {
                SectionItems1.Content = "Acidic Crystal Spear";
                SectionItems2.Content = "Acidic Great Curved Sword";
                SectionItems3.Content = "Big Pipe Wrench";
                SectionItems4.Content = "Black Steel Cutter";
                SectionItems5.Content = "Blind Man's Double-Sided Spear";
                SectionItems6.Content = "Bone-Cutting Saw";
                SectionItems7.Content = "Booster Glaive";
                SectionItems8.Content = "Bramble Curved Sword";
                SectionItems9.Content = "Carcass Crystal Axe";
                SectionItems10.Content = "Puppet Ripper";
            }
            else if (GameName.Text.GetHashCode() == "Lies of P".GetHashCode() && sender.GetHashCode() == Bosses.GetHashCode())
            {
                SectionItems1.Content = "Parade Master";
                SectionItems2.Content = "Scrapped Watchman";
                SectionItems3.Content = "King's Flame, Fuoco";
                SectionItems4.Content = "Fallen Archbishop Andreus";
                SectionItems5.Content = "Eldest of the Black Rabbit Brotherhood";
                SectionItems6.Content = "King of Puppets";
                SectionItems7.Content = "Romeo, King of Puppets";
                SectionItems8.Content = "Champion Victor";
                SectionItems9.Content = "Green Moster of the Swamp";
                SectionItems10.Content = "Puppet-Devouring Green Monster";
            }
        }

        private void SectionItems_Click(object sender, RoutedEventArgs e)
        {
            if (sender.ToString() == "System.Windows.Controls.Button: Wanderer Hood")
            {
                //ItemPage itemPage = new ItemPage();
                //itemPage.InitializeComponent();
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: Thief Mask")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: Wanderer Coat")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: Black Leather Armor")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: Wanderer Manchette")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: Black Leather Gloves")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: Wanderer Boots")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: Black Leather Boots")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: Fang Boar Helm")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: Gargoyle Helm")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: ")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: ")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: ")
            {
            }
            else if (sender.ToString() == "System.Windows.Controls.Button: ")
            {
            }
        }
    }
}