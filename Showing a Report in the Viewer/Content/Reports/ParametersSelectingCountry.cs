using System;
using System.Drawing;
using System.Data;
using Stimulsoft.Controls;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.ReportControls;
using Stimulsoft.Report.Components;

namespace Reports
{
    
    public class StiParametersSelectingCountryReport : Stimulsoft.Report.StiReport
    {
        
		public StiParametersSelectingCountryReport()
        {
            this.InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public bool AllCountries;
        public string SelectedCountry;
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooterBand1;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand2;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand1;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiText Text13;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiText Text14;
        public Stimulsoft.Report.Components.StiFooterBand FooterBand1;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.StiStyle StyleHeader1;
        public Stimulsoft.Report.StiStyle StyleHeader2;
        public Stimulsoft.Report.StiStyle StyleData1;
        public Stimulsoft.Report.StiStyle StyleData2;
        public Stimulsoft.Report.StiStyle StyleFooter1;
        public CustomersDataSource Customers;
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text6
            e.StoreToPrinted = true;
            e.Value = "#%#{PageNofM}";
        }
        
        public string Text6_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            // CheckerInfo: Text Text6
            return ToString(sender, PageNofM, true);
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text20
            e.Value = ToString(sender, ReportAuthor, true);
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text23
            e.Value = ToString(sender, ReportName, true);
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text17
            e.Value = ToString(sender, ReportDescription, true);
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text18
            e.Value = "Date: " + ToString(sender, Today.ToString("Y"), true);
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text11
            e.Value = "Address";
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text10
            e.Value = "Company";
        }
        
        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text12
            e.Value = "Phone";
        }
        
        public void Text13__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text13
            e.Value = "Contact";
        }
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text9
            e.Value = "Country";
        }
        
        public void DataBand1__GetFilter(object sender, Stimulsoft.Report.Events.StiFilterEventArgs e)
        {
            // CheckerInfo: Filter DataBand1
            e.Value = Customers.Country == SelectedCountry || AllCountries;
        }
        
        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text4
            e.Value = ToString(sender, Customers.Phone, true);
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text3
            e.Value = ToString(sender, Customers.ContactTitle, true);
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text1
            e.Value = ToString(sender, Customers.CompanyName, true);
        }
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text2
            e.Value = ToString(sender, Customers.Address, true);
        }
        
        public void Text14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text14
            e.Value = ToString(sender, Customers.Country, true);
        }
        
        public void Selecting_CountryWordsToEnd__EndRender(object sender, System.EventArgs e)
        {
            this.Text6.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text6_GetValue_End));
        }
        
        public void CheckEndRenderRuntimes__EndRender(object sender, System.EventArgs e)
        {
            Stimulsoft.Report.Components.StiSimpleText.CheckEndRenderRuntimes(this);
            Stimulsoft.Report.Components.StiSimpleText.ProcessEndRenderSetText(this);
        }
        
        private void InitializeComponent()
        {
            this.Customers = new CustomersDataSource();
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "AllCountries", "All countries", "", typeof(bool), "true", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true, new Stimulsoft.Report.Dictionary.StiDialogInfo(Stimulsoft.Report.Dictionary.StiDateTimeType.Date, "", true, false, Stimulsoft.Report.Dictionary.StiVariableSortDirection.Asc, new string[0], new string[0], new bool[0]), null, false, Stimulsoft.Report.Dictionary.StiSelectionMode.FromVariable, false));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "SelectedCountry", "Selected country only", "", typeof(string), "", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true, new Stimulsoft.Report.Dictionary.StiDialogInfo(Stimulsoft.Report.Dictionary.StiDateTimeType.DateAndTime, "", false, false, "Customers.Country", "Customers.Country", "", Stimulsoft.Report.Dictionary.StiVariableSortDirection.Asc, Stimulsoft.Report.Dictionary.StiVariableSortField.Label), null, false, Stimulsoft.Report.Dictionary.StiSelectionMode.FromVariable, false));
            this.Dictionary.Resources.Add(new Stimulsoft.Report.Dictionary.StiResource("SelectingCountry", "SelectingCountry", Stimulsoft.Report.Dictionary.StiResourceType.Xml, Stimulsoft.Base.Helpers.StiPacker.UnpackFromString("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"), false));
            this.NeedsCompiling = false;
            // 
            // Variables init
            // 
            // CheckerInfo: Value AllCountries
            this.AllCountries = true;
            // CheckerInfo: Value SelectedCountry
            this.SelectedCountry = "";
            this.CalculationMode = Stimulsoft.Report.StiCalculationMode.Interpretation;
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Key = "264a8493958a4d8f9c334051df6dd5a2";
            this.PreviewMode = Stimulsoft.Report.StiPreviewMode.StandardAndDotMatrix;
            this.PreviewSettings = 125772287;
            this.ReferencedAssemblies = new string[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "Selecting Country";
            this.ReportAuthor = "Stimulsoft";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2025, 1, 9, 15, 58, 48, 905);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportDescription = "Showing data only by selected countries.";
            this.ReportGuid = "16b074a225c14532a150ad7827a71cb7";
            this.ReportImage = StiImageConverter.StringToImage("iVBORw0KGgoAAAANSUhEUgAAASAAAAGWCAMAAADvzq7aAAAABGdBTUEAALGPC/xhBQAAADBQTFRF\r\n9ff50NDRqKqs/7SG/8im/9rD/+bV/7F+2tvdubm95OfoxMXHTEtM7/H28PL2////Qh3xwAAAABl0\r\nRVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAE9fSURBVHhe7Z2NuqMos4WB2Z3hJ+j9\r\n3+153lWYIGLM7un5pudM1k6niYJixSgWq1a59YOXcOOCD/b4GOgCHwNd4GOgC3wMdIGPgS7wMdAF\r\nPga6wMdAF/gY6AIfA13gY6ALfAx0gY+BLnAwkIu+tlLww7oYDtXXNfs8Lvqt8DigksZVS4j9R5cm\r\nxzcuud3v97ttMN5Dv8bnNdx3GwSO+oel67pWP276n0Gkg6vzy3q/jz3y+yO834OL47GMbcI95bSo\r\neNs1Z2Muj9XXO/Vnp9CxO/8M7nefi75ad+jQ/giXexhPiomB7vew8Fu63yuVyx27hPs93O/3UO41\r\n3MM9rIv9t67FNpipsYb7crunG3Vz4kSk0j2t4Z+0VbgHt9IbH1rv6Xm55/Ue4j3cwv2+LOo+pxpH\r\nuW8/dp2fDHXjPWQsEso9hnuImKCGe9YOkt7vdsLRSrsv4V4ze6Wxx9Ky6X0d9/k/BT+xVO8czp1+\r\n3ul6SXfvdIThHrh0pKSu+nC/Dxfe0UCcFGyFK4uscL8nmSLdOVHd/e4C652dnnYeOTs5w33x91Tu\r\nZb3fddrQMNxZ8A/CJX21cQ0YiNM8YIh40xmU7vdwu9/5tXFE7RfRNx8+F89B3+8u5mbfUnU5oWng\r\nbHKe5ZUvRNd07zzlHyyNnnMncc7c7w676ao/7ON/ioRlfLh7rKNjyJ4TpuhkD0sOOgOyzieOYmg/\r\nGkjnDGfRvdzuwX5wHGO56dyMge8g6RTTpvh1Y5f7/b7QijM12Td1NxseftX/W1hPk34+stHdJR3N\r\nXQbieKvdujmR8qG3o4FqSvwIs4+rK35dfYnrunjv1pxyTosvzqW8Zr/dIpeS4rpm6q6xLCUvKa8+\r\n0pKRASYf75z/W/hQ6rr6tHhPh27e0cNcavE1xaX4ZV0r3Xclr2vmaHqMBnoPOmPeOm6u8OOyfxV+\r\nzkBLCGE2+Dnidk9tYP4vxd5A7l28Xfntir8VepN05dXl+tf+Dgt+l7/DguPfVou33iZduS04LBpP\r\ns2HRvPhboT8nhieOxyfHGnc4hvGQcnZRVdfVVVrQJDrnshqziYyBozWkQuQ917bGrXqSc67mddvA\r\nPw0GdSsdcm5dODzrnjpnfeYIQI0u7q+ZY/dddDnmnCPvKqxLjkuM0fm6agWvVevXGmuMOcZY9Z4j\r\nNXLOC2Uqxxjtyfcfhctr62he17jwf+ucCracbuclr3nf4dFAa465ehp5DtFXjlmbzlG7qTlm71b9\r\nvzpZJeboVInKy2Zdvg8faz56AP7ncDIKvarrun15vFX7wvmuc1wprthq13b/sf2ulsVuPZw967os\r\nrrqlVrcuVctZlld+VXVdnHNaz8/Q0b66lYJbtKG6jLv4B1Drqg5yXNW5WqNbF3XQubyslatHpsfZ\r\nLXzocNF7jvaAdsj/4vHNNy6M79f8j+JjoAt8DHSBj4Eu8DHQBT4GusDOQLcfvwp/ZUvfa/u92g1X\r\njTqb7Az0489fhT/+GJe8j69vtf0aF7yDi0Z/dFYZDPTHL8LXuOB9/Pmttt+r3XDZ6P+RgX5uT1eN\r\nOpu8aSB+NN/An1+zLry3jUPb1/s+7Eg/8AtYo/Oa3z+DbjeO788/9WYFlcd6G75mq25ff/75x+2P\r\nP79+PNpPag1t//y6/fjjZnbSta1bB0YDqb7qUlMXw6HG1uhRc+uIjkzrO5u8Z6Dbj68/vn788fX1\r\n9cXbH/bf16F3G6Y/ky/348+vH7c/vm4/uk0cMLT988ftdtP+2653aw8G+vPLPTZ+o8d/fLHPAdZo\r\n26o6QrvH5r99BjnMfftxuzl6e/v6sXwtdPuw5w3jYdB1qqtRe92WL07MAw4Gop7aLLcfNzc0ORjo\r\n9ic2pe7yQ53+url9HWv055dTzduNzd9+uC/3YzuizibvGQib0MUv/menC/vllBhrGg7XEfXn5n4s\r\n2syP29cPR++/3NdhC0PbP3/cvv7gGGgpS/VrJwZiw3Tyi/EOJj09g5YfOhqzEX9/fq3Wn2+fQX/8\r\n+KEXZ+Ht9vXHD34kP/44fDMPTK5BX19/fn19/WiN2Ravsdah7Z9fX3/+8YM/3mi03/L4TfzJLm76\r\n0Xz90O54Db2xRl/tqHRY9OaPr8XWdzZ500DPq+qf7M2GgrfT+rNrkF04bQjJx+2qO+LQVlfmtv/j\r\nnWesbVfy55hvep22Rna7sUuzbffWtvb9M6jHs9J59UO3v4Hvtf1e7YarRp1NfsJAb2ByDXob32z7\r\nrcobrhqdn0G/Cn/lWex7bS8eq+a4aHR6Brntov5fR2+TrvzBBEcDtbnjturs1/gG9rP8W3k293+A\r\npsjb/rfp8uO0+QYWPzf/Hbwx/TPWKDEX41xGOGO+uJX5VK1iqnDHfHgFV8qDsw8DLTOruS6pHjhc\r\nR7hSaso+rWtMuZRcvEu1xJwW+G4jIswwWGT0kfLzoChEzc1PJ8DV8gKDgZZUckjep+ITO0s+5hhK\r\niKmU4n0pPvkpb/wA79eSUmRLJblbcKkUt95S3o7lBTxcPu99XEoO0WefY9AGsx+jI6id1qj+pmVN\r\nKZZSStTHzJsPOfngS/bti3/CJUeVUlLyOflUNEc/Vtp/9CmU5IsP2pNfU8ZY0aeUYki+pOjDewaK\r\nZS0pJ4wbUl1z8p4OLimP/TzC+1JL8j7mFDm2sqSQY/HFTusRPpWQAhZZU/KhhJyKD6WUUFJM3usb\r\nDyUcdpyWoAPlGEPIKR2iOQ4Giu7GVL7zOZbo4xqdKz5mH32uOfKfj28GYcSSY8nZ5yV6SKHZ5+xc\r\n2dOTTlBi9pAu11ycjxBsaF68WyaNM2dH1InG1cDnlHJe6Glk55GVEC6OQTfZ24HBXyixZn2FA947\r\n2H8XJtep9zD76ieLPuixM5Bb3PJ5La6/5e0NVFlvgEyj//R/+/SELZ19fm6he+/XP1ttJehFs1Xb\r\nF2alrXzEyeKfR2+TrswZFLOYU0sufnFLjdF7uu29EaVEQ+LdQ5misvXbxbo4W+ir9uFypHKOOmpW\r\nucomXS5q5aAJZhY4mG/8V31uHYS+tiwZflqNbI8F0Cdt23toT7LSuQnPwF7oQ806kA29TboydKlQ\r\nKjecxaUE89CXkLKvLkSu+NnHCjPPVx9g5wXdnCDduVRyjilqofbhUuL2kFKOy7JQP9cU40JEg25p\r\nMQdfgsh+0afqIUcG62QuIXq/Jp9DLqm6VXfumEoqRwM4hlpLXbIxeMfVL+FCyaHmuhhl8LHx3iZd\r\nGcZqCJ6xhF/b0CelUIp3IVLQuCukEBgs8Zao5WJKrrA0sLAZKGu9jdScLymF5BIHXlY+pRQYxrGP\r\nEgNjtZQd93G6Hb0vsTjPWCymGGNIK0PwkpoFe7iUFwY56mvw4+qXcMGGUO1QdCaC3iZdeWXQw9gq\r\nBIbBkT1yKCm6EEvUUaSArbRZ+lRSDNmFuJbIXjBd0BfhfPEFY6vTnIghLjTOyWusy+mAxVOga6Uw\r\n1m22XaJfQiyucgrVkqoPIZYaYp2eQbRlx5Gv5HkWvAOX+L4T5qVH1wZashPXPFchF89Zmx2Xg1qX\r\nUhZWLyyrcclZ5GJ+NYuqszi3g8yLYxmXkcz5v7DNnKuDDGtFEdt1nWk7jNmuMTn57D3hyh6iLZey\r\nnHkYa9e3Ad6LZCtib53WOIV+WfrFexpvi3ubdGVIqTvU3G4v3GjsX13aNbjdVnjnCkftobn62q6b\r\n/Sq7HIo2+/hkDZ6lxWXssrvs2scJ7Jpv/43rLqDD0IZ179nQ26Qri7r76u9s/WHBX/17sa+Tv8OC\r\nv/TX26QrfzDBx0AXGA0kt1ZbqKffXOHNd+Dxuvt4FmngspxrWqvwlw1G9xf3/xRcct2ao4uEl6wM\r\nECm72dPkuh7UEt5HdvZo6059VOMeU1kjYzn6k5GXSGEN3BwU3eA4qlJcdDFWRsKEiBy8CMIt1FAY\r\nG+Zak2/NMa0rPpca6nIeirgURpNrijWscnPhBfM5uTjxR6we/1rWjTa+40vpoYEi34L6N64Fg4Fw\r\nJzI8wYWEQ7CsnoFCZLyXgjxza4w5MEjKjLBwNY1GFvBDahyeQvGq6XEtYiCX01rqC8dZjnhcV27s\r\nZcGxGBml1KKw2wMS4//AmJTB1rj2NTTUo6fBR3PXjhgOrkQceN4X7zOjS796j4exePk+Uyl1jVEj\r\nRAaBvuQ0k0yRMyowYi6FoTjuwczoMHOOLjGtbG9s8gDOMbxsuKFriesSi4yFU/WIyCkpr2nyZVbh\r\nBeiZuWsZCL9hILeuBPootIcgM5YQdUbgDyFzS9WSutZEeAyfdqOGDpwslU0RjLcsbq2LfulLNo2U\r\nmXOwwfnsYiZGJ9OYS8Vi5em+tti4eejNS2iqBB/GyuhrXAu+u8UHfrrhvwyHM+jNvxbh+Tf9/b1b\r\nf+Ovt0j/wR7BPuht0pXlURyeZh7PYifPQedoXrFZ03EnB1g7tsBVrHMrtmeuoXJfHjfdHvhewR5s\r\nevQ26cp4FD0RztYN53JxOXs5/7x8grsnugswq5V9qTlWbeK5WRcLexkbdGA2hhlVhk7cVXPKrtok\r\nl+ZZ+7ra2oqb0i0Of8ewMzyGOarzfbMHGPCxv35Zb5OuzE8slCwfVfbJ46dilJDlEAo4DEsp7/oT\r\ngnf4e3AcJsYxkbECb8UlOcPm/bVDLsn5EkPGE1dD9AmXSXIF11FIu5YrLjvNdpbsmCMsPuFx8wxZ\r\nfPIhFkZk2Ze5M42JvxD2Ru9t0pVX53AJ4gRjmynEtBZfSsBQXoPD3u32Gi76yKAzZzyROBtTNG+k\r\ndxWX275LPXAEJZeyS0uREyrkaB6ixOxnSsN3pO2HEPge2Q9zuXQaL50PRcekXU+/W+cx0N4T19uk\r\nK+NRxLHM1xHkQSwr30ZKeSl8e8VH79/02bmowXap2S8MFtlc1nx2dow9w9N/N8LFUn0tbik8XXDq\r\nxeSdY/C9aGC3O1DH0J9xdEzRMXDVVLO+HOgFbaQa2Xnf7Akmqkt67yemtU6zMBYJju8K16AuZMxZ\r\naMG7sFuCPG001TsLanXOn3RX2GZGYmbf9KJ1jdLYAeul7sC2m8IUhXa8NVMTLZmCe9NuXW+Trsxd\r\nTN2XEexI7J8ciSra23uwnVtJ723z7eML0JFtx/ayPT/KPew7sy63r892vu3MbHC+12bjbkFvk678\r\njXHi//O/nUk+eInRQI/PrTCMus95cAdc1Xu1/knB2z4++3Ns12ScugXdytcYD/eIYUVM3npX8dZA\r\nvxNjybpV6lrWxa+LX8Z2R9RU+gPTIq9HbvsA3+wMi+46sSy4N0qEeJdTXQKCsvHQjiElG7QrB3Jt\r\n4rDhLcAtyTpJ+EwQje2GCuL0Uf5oIHOO4ANKkds9npKKl4ibra1jITOe+4YH3Bg3QdnDqZNpH2OI\r\n3IyZQMZVddYlUfBSKWtyqVYnn9QK/S6sOcR48AmlunCjhiaY3JrSoglLxhX4sUoqmRnd4pHmG2Dj\r\nR406tn6NGA1UNK2sWdGScmCcGFfGezgWNUEeGFKUqfOzB540PFiiD9I/BigBXxtuttWlF0w+vHbi\r\nQhYmHH1OuIhSCmssaTnsucRbKd62vDLty2BL+4OHp5E1I+npN8JW5Yjc+nXAYCAefxjJBQ+tbYmx\r\niNjmc424THm2ip5p4CeB9QSOidBcI75M8d8irL4iEgN+L6QZz+BgQmR+WDjwYPLBxVuRdWR2dazt\r\nfc1LgYKX17jAuJAwEBJHpoIEO7PMhIwgW/BYVb1az/xxx0ZgypXsMTH1HBkdxwfc5DT/zTE30AcP\r\n7AzUkdD+26/eJl3ZDNQ/lWyPk8YSe3x8C3P3y9HfNYN1pCt3/x9hnbPi4UntJc760tukK+MPijVu\r\n/YGBp8fWZYnQ6cTBGjgF56iNn9f+WnWp5V0fA2w79sbjp5h3DvG4evJ8y57oqRNrr9vrY+dwRWa9\r\njeLfyU67o+lt0pXlD4KFbfSdvOCsyEt2DGgWHAex5sp6Sdw1+uAcLgajEMmpKDIe5CCfHhy9c0BZ\r\n86V6kbMyngzYUymXNPMh4UW0GVyYgEziNlKSdZH9Zs3vdhS7rSXscR2MVX082vY26crNQEWuMXxI\r\ndDGEEGPBsxgSYyA4ZCFE/Gkh7X17PRweyOaoUZsYSnJ4d/KEJbaHY7SVmDRkOO1x6BhNLs6aOkxH\r\n3wJct0CPmbDEM9f6LN8ZH4bvk1lJq4JXDU/c5qPqbdKVcZiJkyZ+XeLbE88uQ5vbCHb8r/lIohzS\r\nqYvFxVTxbYmpqfEzrrKlMnCdHOUO0DKZE46MpTTCNbZfmp5BUD6NIJm8Y/4ZYyhWQzZliXyaJZSx\r\npRiXFqth1MKNAtnbpCuvzjFcUkAG4zm4ghpG1RIZ0BrJrUlYmlrjmX1gp+E5NZFKqVRCmq2ZX8BY\r\n9QDnEbtEpbLimcw+O4Iv8tSp7BgM0m2qaXAI41YDQAltarAYURMdf9quRZDowNjbww3c26Qr6y7W\r\n+F26HzxnbraZkcdcAbg4UpjRdtvaNsiWLhoZ7KJpvbUJim7BiNaZdieA0Gj/bbeGhtlFelvRDu/B\r\ncOxt0pVFwfv/8DosePP1aNjbpCt/MMHHQBcYDLT4B88qutViVZ8+bAcxZUfAewF4dtby8YDKldbZ\r\nRl/D2HYE9lVpHUPYgwEzBVK+7MjYgxuZjif7655OouwGDNvA05Q94SGRTElFPEFd6JFGTqtneulq\r\nm4LLCQb+mj2jGedrXFZccZ7pK23wHBC1UlQ8KBS3JSx4QNLoCGoogZnFCt2KIWHEunktwbE0wvvj\r\nrQ5C2oac4KDXGFc/rzAaiOEcM4c4zRSRQGAC85NphbKPx8oSb1wDF1YkMwqDEsZyZQ0hMx7TJi8M\r\n5CEoEsOyOvaKgW4n+yVKlZhURccy9mKU9lzqA76/kKbZK24hJ6JKSmA0Na4Fo4E0HekZS/C/50uH\r\nPhcic6xlvSnwed9mjhwYX2ZtQGQ9HISKXrFNvjr9FbmsqXXNw0JgyCUuJwaKOIgJThIJQFPBJYk6\r\naEtltDR3cWVxDFOEFjF3cY79lGY2S6uTDjXe0QXNbZYsugy9x3NzsGxyZQO0RuCeaxxkPPTlX2+D\r\nIRRy3asp6dNgev4bIFuhEw6NTjkfsk7y1lUoKzwSzffIUnWG2dhxJZgu7HC1/hJ/eQM/gfFyPnG2\r\nvo1908Z961+HBd99HRb8D17jgvHz5aszSVd+UPDGuerX+Dtq/rM4f9TgJ9xHNU0eX95G816Omzh3\r\nDHZoY/7mxrKHQD3MtcVj7XHJNzBt29ukKxOSmeDapci8BqG6qTHyalxFztseDZ+PLfD0puw2nzIj\r\nEmKCW/WYKtwUfx0W6Euh4kKUK5y7pRoNT1onY+WaxL/bevUtOJ7g6RvO0ufi3iZd2RxmeMmYcvNE\r\nidbKLDDqHVDZfImQn0zkRHOS0NeQEjn02vlCHi/mB6HfFRhixOcS0ronKx2BR1HUuayg3hziUnOo\r\nnrGYd6Pby8HyY7JODMGpR+QcLrJd7vI7d2Vvk67cHGaRuUYsZOEj3ih0aIUwVFSEqdHc5L7jcziw\r\n4jDQmsuqOFJmVEX8ChWP1tQv2IOgXgKqCYQOtRSHUWNM1Sm4dWiNgXCYWbzxKW3tDBFqoPkfn8fQ\r\n26Qr6yfGIF/BFbgURXiLfD0WgMuEeeJs15nGRLT5VMvRtVgxhWPIGeWNVORu4Te8J5ROAG+1OJ9L\r\n1vkbmc7FxHnhWxrjVl1OItrBJWBcuV97ASeKnoJKcnkeQ2+Trqy7mLmejCfXolS1pUb7IoyCO1yp\r\nLIHjpuWjebRvDKHrQoVuSFUifd84grYTTx+sB3Z/1c6Ou2Luwy6Px3VXgB3B7Mm+V71NujIUPKOx\r\nNeJb47w9l2x8uK30sN/kBm51Ntrcs8U7N3vokaIdPnry2MBkVxv/7qfGEc+NPhufGkjD88/fzih/\r\nYRD+38BooPHzX8JwBxgXnu/L1jyG/I1jd1b/dMUbuGw7rH9Q8LbX8ob/b45EXGXbA//EfHHbHtgX\r\n+nSHHgBFZyhTK4S6kKE+4cWYVFVtIz4NxMa3wKatg2dNRwPBKYui3YnBVn7+Qbgg6AEXMULgWy1C\r\nM9oekBdTnKa5DkdESPnQ9HLwKxEbcYXsduIeJWZVXDuRBMe1r3ELSzIBPJxU41owHL+F4RJHy+Tv\r\nG0y7c2CD1a1wBYMy4iokoO0BF16UHgq1DvBp1UDcIxkTokuuEG08NxDRrMyeanMv3EYzECBDKIvH\r\no/iOgW747iR8xLdbw0vH32sgOhJh0cHccxBKmeGU5GTBR+jJqyeZurGlXOmZUGcSD65oFmVHPsCx\r\nngGaJ/O8JGL87glPor0MhQ95k6lxX2wwK6j3v44XBvoA7Ay0eV/+86/eJl15p4K3wdwkT2eJfexr\r\nnAAvy0tnVqMTzCs8PGVGWqC00RPmDSZ4p+KzTl+7t0lXXiHd7YhzuAMibSPEPLcQGEk/oaVcdFUZ\r\nWWnOdEE72O349AYjhsfhmYMCclqUbhs9YmaPB19LinqUwrPeWHfk/LKPS4aDo10+97oHcljbOtEN\r\nG3qbdGVzmFWkwopobHADQylLrLCoKiGhTHeheFzh1B26+gQ6u8S6+tBEuND2Mm6ckfccnhLcAhOW\r\nWsZ5kVINvihmNftQ3epDVQxjSrvKjILIIcuG4dlBYuMGueBGQ+KOnS4ImBypSczcmd6Yy2ETCLsy\r\nEGOUJrqBJxH2nZh0cPJMB4TZUcmqHdxkHUQxi7g0NXUJ0a052iDJJc3UmvrdwUAODxLivCFaSCZD\r\nM0ZNFTmZUsLO5eEkUwxszlb+PKIzHPtUb73tOuwtq3jeNT8qxGe0cG+Trtw8ijgu8ZQR5EAogXRM\r\n4LjlVVO4+Ael+xJf+O8gcTKbHhNRHgALiwxnzLgV3UF9PPjPCGLWlxR8WWopnEKpxhRyWoKvZX+c\r\not1tFsJTjKHwYzLWFXPR+HmQ7Ybu4uPWARuvMTxECHubdOVGwfNwdeHKSXoxeqdyNKIotFXjrCka\r\nYr/DHk1WTiQ8tVCSaGPuwUitWlphwR22QsTIwmAxFnZuUnjiIRONP7oU0eJjszGikWmanRnft3EG\r\nWcIEtFis+5ai76lzjXW4Le9t0pUbkfxxgeaNmRaVt1mYbUbGPr7AY4rBmrClrTHxvcf7Ywd5M1sA\r\n8eP6+7zOj1B/H3NC+kTMsBZYI4kNbs69vuV2qI+JJqG3SVcmi7N158Xr+Xb5Oix4//V8+8nX47t4\r\nfD7WOX91JvmMpC/wMdAFBgNVLyJbPXG9fAMduY389A+89cRNHASzYrUS6BohqJE03nm4M2PfEKta\r\nGz1sIrjPgpd0G8l+nnZqWI4MRcyErjKmNoFUxCUo7GteAXIbg2HcZWyTO82SCTRs978XZMfqS1pj\r\niWEpqOCFGuU+g2rm04qzsUcpq4IKjeS33YEjHecDKnchiva3b7cBmZq5LwgcDbQmaSVrGAdVblOx\r\nO/HGnOEWEPEVmU5awIpeLfCppMUC7+zUQDG6YjHWBW/PkmosEQpeya6Y77aDUy4L/upqM75MljPs\r\nMZU+KftJI2/fboOPN8Z4Jxg6GaVnwn+o42gAyxwqjr+TzZ8BHUSN2RSOIhE8iHzZUq0wWT+nvAFi\r\nXNeyrsUV0wpUwpEafeL+HUZ6lOlTMwe7ErsLx89LR0W7NbU+8o+cfMVVA+Opt+xoIOho3OUYVCB6\r\nh/rd6pPGGEPNKziYd2q1SOgS+SNoclwObLAytnjCGHRS7URxb+P22qVkZOPB0IMl2BiCjiGmfVQz\r\nHQku+dMjYNxzOrtxtrzHbuD0F3Daid8Z+z7bAOuAs+Xfxa/azt+O3iRd+bUK3nFS/Ljkn8Mv7cvp\r\no8bmxHs+ZR2fezocnv12eDR9bPK5+SvwLbbHQHsKs9jZeWst3bryqPIWi+Sk/MJAlalCGHfqostJ\r\n+TQQrnNRXLXHI6BzSPBbadoXmHaswhnJhuHQHZlocxCxkFHqKj4igCf6FG8H14ixiTYVvKVyP2k9\r\nHisegEzaBsT6OBZb09ukKysrguMGmUyagowMsNeRwYByBsMNupIkOXLVAAAm3kSODApeS4CAswZ7\r\niSU21ptBKniZKA3pk1XigMXE8yP9TrUTinkKQUBTQ6R56F7XscNZEsDGF5NWSdy+wN4mXXl1Tk5S\r\npALFIXOhVkXjMspSFq8Ev7IFwS54Bi10dty3UfDw4WkYwjevGNa8dwaeALHqVJNbEq2gN+awiIkX\r\nj+5HhT1LBY+x7IOK59OR9DaAnBGMlVSdw2C4aVbtbdKVcZiZw9VCNvAHYtcnBc8np2hZaHUeQhwa\r\niyHNmJNVY+jIBLRPCio3Mt1YbwKp4JFXQxLLzK/ySzNJmKOBTAWPM0ER1Qz/iR/mfBqrDiiVIT3O\r\nRy+FSGawrX+9Tbqy5sUUZqpq1RnNTpdH25libPVTbQ6WNp8wA631v10w3w9YlQoeAnjysrXG8M1a\r\nookDrI9V80Jyo1qs7OXOdMmBu2lkw6byB3qbdGVR8Dpsn67O1bfx5nbk/Hse4Juttprf661xBcc2\r\nvU26skbq//q/w4Kf+etN8sFLjAZ69QgpXK1/YHzysob9E6PV0KOk3jrYcL+taoVWPsV4KL8G41EQ\r\nugBRrlqPW3iQnXWORLRlZUpOp3Ik6E0baBV6ICqixdTgAT7xDkvMFliwHpQtpCFQgntuwSnOYy1+\r\nYVhBKLFfJMo/JZD5tMqdw6aZYrWNb0tbF+Zcv8exIIs/fqOGYSFZIRQoIZ007q8StlC2KwXkimsP\r\nnY6hI8GMQSkJjv6imvALKimsmHdKNJbJiMDssQabuNNW6Q4nhpHPrmSPptjqydcbCyIXsBVLytO4\r\nSi8pZwYiqG80sb5tqe1JEh4zjw+jJuWi5XuaSgUOBvJ+bTloGXWgzUeQiBSHlQAsBfLLoqGTCAvF\r\nT1gIO5EwyH5TJoPHqgAbk9nY7CSsR44NAj0Ycq4L+R5yKa47gBzhbEoTMSDlZ1LScAlnX7KS57JN\r\n5f1Ai5BY4MdS7YkPYzugqWKMxPc8uiqFcY8e2Th4FLUSrqqJR1gWsOCgXhLCrplLZkYj+Vsjyick\r\nQ9xviBameCcmXi0IkyshLUXl7WM6s+WnwTP/bLuQOpaQLMekqqL1M77sOPrrBU2gst2mvLLkmNK2\r\n1PaE9t6sqR2L5FNQSBnXgtFAvwdyi7T9Seyl9xoD+SfxF7rx38DOQNOB/H8RvU26sqWNmFvpbPkr\r\nHFu86zJTpeaeac99j2VHTBdeY99s+6D/e5t0Zc4g5vQab6BtQm+kyXL5qTB3DQguu43wH2TmNx6V\r\neFJVSivS25LVAXqYLZu4wZz4gdrPe11ryDSjk/aMa4QSYwT2NunKijiM6MhJz8rBqKGfS3ZSboDw\r\no9S5bxwkVHEy0WqOM2W8Dwi/MH91eQxK3Bo0bCqMFuTViqEuLDu0VgoBvo7G7xvXn0AMr1qJeiCT\r\nmhh4MS/GCOxt0pVxmJHTXt6VJM1iVO+CQkuqSHT6OGa2mAFiHE43Jjm1QfKvEpA5yyU7wCGKSzKN\r\nBZFffDYEljJqIqXvobYlom2dmziMTlAZqsLYEwXO5mLBawMpR4iREmPmGOU81BnkdbiMqog9Hnc3\r\nQmdQS/NqiTpKznxN5b0zqJDvJIXKmCamhe+LHBn56HRVIlrFaki6b1x9iqxYXvyAUrSR+CHjyZcG\r\nqnDSxLcjYJ6kM4y2EgwtEdsaKeCgJzeBTnp4cQH9HtrkCkVuchE5QtcbRoecdVzM6EoV1W6sKqay\r\nBInUuYP9TgGRRcRAOkVRn42G19ukK5sKnm5lyi3b6FZK0qtLGX4lu4KPHqYZWiZZ8aR19SRi+L2r\r\nqLyPdtE0zxmBwbb3CZpjc7ufjKvPsPEIN7GJpvtH+94mXbmj4Anb/4ePw4pzvF1xivdbd53+CRyP\r\ntzPJZyR9gY+BLjAa6MlhEylNj8AEtZmg3Xd4Ho/H5/aQvLFWWLzpqS1oobZqPWCDZXKmolmqB31p\r\nqK7cMg5OG9Fd2hZ7tp+5y66wpdVdTrTrhi1E7xZfMzmgGEBJyVWCcvgDJAaN++EtMCVKlk0f2GLm\r\nkVosb0abQeQ4+RPdxMcjCl5AujU4KHjUVA5SVOcO39FGwctxWXNgtBgXb3dMCPrHzfdwULxEcT/h\r\nVw3NS17xhTGuY3ZyMd+TRmFahDbMJMZ0goU5V1hiyqIFrS9mwjwZsyiTAx1ypSq5yABR8HBMwXRU\r\nWjESY0kBRAlR9nCFIdpGwbOUETklp8nhF+Q6A/OGONlmwcVgMFBWIjkLSkZ+BWckMnOMyJV1hCn7\r\nfZMTMKeK5KKikX2E1mf0OMmhaJaW2I8aJ7ljRcHzjHxQD2K+FEYf3lscdiNEwbPsZWtamMBVYhBc\r\nvdAJXp9BK8EiFuNx3DIYmzMmsJLowPbfto4152mj92DD8pWTgnaj9ekOqvkAbqlQ5+bUPl22HLxE\r\ndtp8Z20W4QBU+7RFo+CxZWsn7t3R/HuoFbf4cUXD2fIPGj4GusDOQG+TC97CY2NbYcsf9/7TwD+F\r\n3iZd+dcayJ4befbTg91zkXI4/N7obdKVf6mBcoDBVCGX5MQ5I704USST/vud7dTbpCv/SgPhMDMX\r\nlN4DXKqSLVO9IliP6VJ/I/Q26cqHXM9WfrCWnr6KqddhB4cvUj5FhbmWFHDnaqgpOb3XKW01RdCc\r\nJO1NpNf2zD1W7svjNhsD7BXMH9Ojt0lXNpbrM3SSvF6wRzMRCT4unnAk5YNt8pOv9stMLhLYDDeZ\r\n3CTriNK5QaTF/Ubm4bHRBnIvo0uHUvYz1zN8v78j1zMPGm/meoblqjhs1Fkk+6xMyZL6i4vle9YI\r\nHhZqeck43CzYvnZF4nbdPnxpHcRyhfYRapfruSqjcQkx773a5Hq24fr/Itczo3ULJlLylaYxqUKs\r\nlu9ZqpFGinjpAcbtyF6bu25c/QJdrue0LAoLj8whcCLpEWWoP+R6llTmI9ezMgde5XpOb+d6lpo8\r\nQURGCZGGpMlOhlyV79nrycdD5yA3Ub/ZPWBFR+eivhw7Y96cN+xyPaNMafRWEkBCNOEc2tfuWK59\r\nrmcxdUWE1rG8yvWsX0S/qLdJV+Y5xqQd9b23LM+mU9ic0FppjNNSTkinDYnHS4d0lBIyKl8lsp6v\r\n2mx45HqO1gPtqWbJMB784VbDdBT1JSBT2XI92+XdzmDjax5hki67db1NuvL3bvPHMP0dnPfEv6Hl\r\nYDcy8bXL/DQf8LxvDtZ8vcs9jlWPS87Q26Qrf89AF3Aoi2Vu98SEZnwoJLK8nnL8HdDbpCv/UgM9\r\nvn/dsbjLUizjBfb3RG+Trvw6XuyX4JeGdf1tODXQRmr9O1+HBb/lqzfJBy8xGmj8PCyarH6Nbzf4\r\nFXh7p29UHKrELWN2bbNZzPo4Iq9zgkZMnmeq7VvNoGh3d9CRQD31klMpzm9dkqaETP8fmjBNJ0xU\r\nHtKe6dSVWZw+bunU5UOf75FQqyuMBoqKKIT87G1ygIevXMIa/SIBA/Hdeb4pWIBpoP0WNpBMiIxO\r\n0KCZImFMq8okEBgrDyBYDPKuS9BNkBVQAnqJko51UXwlPz1PjLDyifmzdOqEq7V06qJyH78X1DM0\r\nEYUsPsKskzmTwUB4bSRuujDXZGx4TdaQMdyo2YhVKPMlfguJbc2B3BnaYKaFJqYQc2qeDEpj3QFG\r\nmwphhY0tA5EUIZNHYLK3km96pmDublUCUgXvKUe6GPESj8jpMAHnkntkyYSxVWZqGcMScliQ25Rp\r\nSdI24JTgmcq7WrwxyTkTyDzZ/Bin+dRQ0ffwzFFvrd7XkmPwa/GacH0Jx4P44vwaybvOjzXG9UZc\r\n8PEsYOq5kE5d+1ljXTCJTQLLjeEznhdcL4ejZwVcc2a0i1+muruHRn8n4tUs3j+MgX8u/N49/g2w\r\nM9DGRPrPv3qbdOWplutkyXtoHsXn5+fybumGw0L7/Fz6grx3uuINzNv2NunKTctVVXg3/5by3ho1\r\nUSzBNx9oYW56xFrVUrKp5mqNXrqw9vC6EQOXKKXER3drzTiAUE6EwsncEfmJ9rto2FY8396HtMW3\r\nI32it0lXFg04RbwuW88y6e8yc32Vm0HNbfLvEi6HXJN3uMSzGKoBPkuUPjl5Ny11dGaUBLlFI66N\r\nw4pIVfBK2pPIkI7XWVIB414AqbM9Hjz6qInK96Gk74r3QsbsufneJl0ZA8UcuMfj0bVsPkrbLcFT\r\nZTU/6KGeQLK5CGkYBbmQ6kc8b8Z70iiFJbTJwtaUF+U9t++RXJpkr2QM7SxHp1JeTv1ljUhu029h\r\n7pg/AwZSbk1jRD3Oot4mXZlZDRzQAWqW0htJryEkONcS6prooZ4AMngslYzoWJVzQeGSUNVFbjeD\r\nMTorymwvZpV10SlDPMyriDhFS8d+tm/4UxJjNSL5rMopLOm71FwJjHzDQMrWaTKuylGeGWAZn41h\r\nF6/9Lk7hII7n6BSviO6y9JczBa1BkYO4Rk5xfsONDG5tq/RfI9lrbUyqweLZ2aEOS2fPP/J9vwnR\r\nz5m+Y+ruDbnkx3VTV2WVdZHdysebzTmouYk98Na20t6ZHWgZ2TcOeH+fei7b3X/naFs9u0Feod0v\r\n+ra9TbqyxkHbJf1vfenfuPA3evU26cofTPAx0AUGA0k0tccoKHpKdjwAxX+31qXlVD9u6gW4F8W8\r\nVpQYuXo7eOL8h3jYSD23lW0vV46CCZCbdsdH/YZhOcJaNdek+KCY8QK5SJwiQymE/FFMvSJnG/Dp\r\nrCu+KI4sk7tGtzQFW+70bw9YIJKLvNBpuS7EBnL3Hz1QEMlrYbgHkXxZdGuMdRQ6OAXzdmep2o8G\r\ngjsuh6ImrCW9quzqGrag66Tp8SuPF4hlKWhmVelgScVB4XmaKH8tDduI5NJyXZD1qIgQoBMF8WR0\r\n+1mSJCOSw+NAFIx9vm+g72i5SkkC2gueMnTaJN8BMUfiFOIx+Jnjc4QzA0nPixEn3il4M7BS8Ii+\r\nolvzRLJpuTLKQcFjvTGGdTkto1OpKl87o8pImIDCSenpuwZi1nfmSzSM16AMUaENLFjJAxkzRSQp\r\nXzNLxVDat5rBZYfbXJOqePylsFK1TFyNsX4PR4429pGj8jfBOecyo96NXdZ2q1szlZYVOoiSwr9/\r\ntUT65bT22fJfi32aqb836RRfwS/EeAb9TX/7Lf99++HvV2y9t0j/YZykfuKn59R/uuH38Et3c/6o\r\nYVefx2PAzzzZPHDyYDRdOMKezLZHNyNgnjbs92OPCt+A1W5qhA/0NunKUl5oLNG8VO9Qb6XsYZF2\r\n7d9Bjh5ObNU2mv9Vmq5vbEii5Qy6SkYElklEKK/zQ8cD8WS5QhTcYaw+oFhwNeHnXd3eJl1ZHkVu\r\n64gLRERKlQod2QM/98WcA24iQCDANNohznp4umPVCaSoxbRsrUtMC2mXTrlpaLkykGAHjLlap7fd\r\nnrQyuBiIN2QemanHa3eHk2uKjJSpZtyeoriSzuklX3MCh9gCDixkZOV10+xlnWWDOkDhhcV7ZDmQ\r\nXmD8tMRTTQt6/GC5bimWTGR2YK+OQM5VWqumd/s4CXqbdGWTptAsugjf4hcqcI+Z+GHbV1A7MpJi\r\nGM1UM09PvvaXXQa1FokQ41VzVZRsDeJPGkrVQwNF3zyiiiGUi5hpg3O4jJZuOz4m1bcVvU26MtM+\r\nyvZmtwRqmgLr4+P3YHwyqMXaRHZKpz7WmkMzKIQJmX6NxHbGOg1smLwA1OCqY3Mv/EKN6voKbLMR\r\n33qSZ2+TrmwcxXbP7LOmN6bt99Dsw3SDtd8WvIHW8NH51okTqKPtKNv3anY7b7KhJYpv1nks7W3S\r\nlX/FCOv/x9/OJB+8xGigx+dxhS04Ufyc4Vmvb/Fu6w36PmnUdv/d9tc4P2JhWKrM5SoUKSzUh3OK\r\n4HXIbe4NVwcgJYCVCkS3lpZdUTf7ijN479eU/eqIq3e0V1RUlNLpoXJZtVBsv2eKI6vIk7rt+uHZ\r\n3CM16l49oeMNBvJ48gitiNyj80oWbWRYJZoQ4atJfXTfaIpbIFETaS7xCopDR9b44t2EJDYA8hYG\r\nqk6JFBikMv+c2MSxtWd2VI44BT7BvEtlXVD013BROYpg4Y0NBYvMYVA6Xz8aiPGARfQwjkDYlS+O\r\n2VCN+cgWlWY8uAPwXCGClW+ov9JX7EpXD6fAAU9pioUvbE0xL/g0K5knxsqottq0LfkJxJ9sWq7w\r\n8HCBeq8Z3KmLjiE6Av08O4zrhPEnVmGYSt+U5x8X1dkgrhq/DnI95ZfewA3owTIpXDF6dt7jNkXE\r\n5Y3zbykrTq8irkBZIH2iVsGejbS6g2TDCjoxCNFKzxUl3pWpYSMLipM3+vobCqGUnH2bIs2A+ZVp\r\nwFtO+mu844g02El2faqd4L2v8D283ef/KnYGsvnxz19vlMFAHVWguaK6J6D+Ych8WY1w9lixazA+\r\nOw1bGlfv0dY+pssvqv8FzDbc26Qrr44ExOQN9kpazn8LxDnU6fXAaIQ5NkkqpKyJThgtTRB1iZ5A\r\nOttJlb5CyxZCIiVlEtE3ZPw6l089BBVdUz3GWbJvdtGetiaPny0U045Uyd7NqJk0x7bHzcxHNA6e\r\n2jzQ26Qryx+UEQQlp493MVRSCelugOZjip58kxkZyMBNo6D1Hcl8LjbdoijfxkOCAESGxCVA884Z\r\nGrjYOCAtTrfW48EKeI1QhULLS2HhTd3VuSBN1z1YYZuF2mh0H3ZolSENMp2r/8emMKjIsi5l3W5l\r\nb5OurHTq6CNkCGlhJUweRxc+rxjI763RUQjVLciPwuoSQw/XT0ipOhhklgqJTOWLqIVEmFsuJcpk\r\nCcCNRbBvOHP3WaQ7dCgGfZGM90rkbkS84UxABENKWYz11MOWTl3qs8oPz5tUV/ctaZyVUtOLwffc\r\ncG+TroyBfFVUBwHysMvw0yERJgYfo2EL0s/MZkpgwsIxoNmVkDMmNe8s3m1yqras8nj3LIJdjkVi\r\n4sWsm572EGFTxUBLDpZOHY5eSHIAjmmx2JKlgMcpKL9cl06dMH/lsFJUxnF3VYEcliP++evtbdKV\r\noQHXikhylBPK2K66lHACQ3U1RWJkhk0IFTKd8pTbGc71YgvbRoJO6qu6rjGtziGrAD8Yft2kwwLj\r\nUpdrqpXfd/UR4VVd6XI9JlaLjgQEiroQmU5DRfyn+kA0CWH0CW3YsSlZ33k0IOykF4HubdKVuYsZ\r\nW/nRcZuJ6O9U9v/jkrYlPn+seTY15+F2W9wmGew/6cWemIduU5EvifpbRnfb9LEV+2lbte3Ta49W\r\nd/Mwcpth1mNsKJg0yTCv1NukKyMk+bzi/6LXYcG0NL5a03Hx+y874Mc+np8nr+OqziSfkfQFPga6\r\nwGCgRXnLXzycvqaG9ahMVtoD547O0U5gtuM2IVXD8wkzVufdulQlYaorlKm8nobumStsp5ioQ2j1\r\nX8XvKRX7SwymIOoxI9KP+irJCSJqIsruQiZRhW5EuIfXQPUnxsABkFGUrANsFoEmNh0wXynclBjm\r\nQfJ7GED5Nf2Kz87JZ5fWHAhimCMQmiinhzpXU1wDN71UM45MWsdVPPaDI4uk73bvVTb2CUYDQb8j\r\nMhWOHGMWBkUSyJHUPQMaOdLeAFKlKHOtmdhefFaKN2ASNLFpcrzj9Gs7YB720RkCVYltJREl+j5l\r\nWfG+zZ0YGrTxx1y+OkmMNo4/5WpCU8imFks6eNtugZgQVhHgOq4Fg4FiXEQhVDosadMqJphMRcyy\r\nwqUjgfu8p3vc0IPl4eNGKiMb3ErL1aN8y+i6rvjf2EH2pCZ4fL83soaiPkxOMaeMl2tBaWm/hwYl\r\nr5eR9dVKbZaUXppYTSujTs3qMmM8tiVJF75HWIdzn+tgIEh3dYW9Wx1+9zWvC3w2/pRujUj03Tjh\r\nFIq214UAgtyWM7NyMYG2+7w8tR10W2U8CHMPXp29K7f73D5qWxF0zSvDJOm3kirOOCockvMIFXJY\r\nY1sdGRRgx6BrXAmmCxvOycP/Nkwcte9ib4LD/OJ+wb/377Dg9d/OJP2HbXJ6Q5sj/ym8PRH/W2Df\r\n2d4mXVlazN1jSoPx0+brXmD/aLi1tUezK9jzVEfBE+fk8VhwqH1c9h7OGvY26cqNgrciJ2dyk746\r\nh6KF49F7mtL5FI57U3tC5XJpRMPqC3nZx8ojEjoNpi9J3k6e7aHk1Vp8HZ1ITmmdH9ivvAA7EIzC\r\n92jc26Qry6NYmXuzrOrIYWTSNJVVPpN5UO0J5JyU/rtIWcqriZ5myJepkxx3Xg02Et6XVOmAxF9w\r\nMR79QdLOYGKSfexXvoZLxDHih2H20JeH7XubdGUZSIL8JCaPKRCJ63B2rWKJvUUv3JBxoSmtphnX\r\n4lDJBnptILqgtKMbBY8pXih5aA+OvXApww4zbckni+49yFVGsLHoeg+PWm+TrqyoZ6VBT4TZWoZx\r\nZECTK5V4hm+cQQihGLsNnZyWQysSU81s+2vwpCFFS6PgKe4Cz2uGc7mUwW2Pv1oxJETZvNCHncAR\r\nOqKRK7Hn8uPZit4mXdlyHMoFJu7VRpfb//cu7KpaSViOPxwynpG53jgEKm7p0wkQ0aJNK3LshyRR\r\n9fda+fIICVgq35Hdxh4rept0ZSh4je22keY2Jlyj430Dxrnj7zld0G7+19vZGm8trBvNPGPljUN3\r\nuFlfw3bQDvG56VMDHQZMv+bvsOD3/+tN8sFLjAbaPo/LDfOlc1jdrsXum3m9pS2fePvP1A3bilO8\r\nWneCN/gmQw0TucMjo/935kKR7v2HPlwBylm0bYPps8akIWxw6lto0AycBLO4ecndkZg8YmpurCtW\r\n3JOCRzp1ddUT6zpWHYDkOv15ZaZhnU81ibBmk4Soq2vSclG28nK5yydumsNjXCVl50wSHdxlOaBu\r\nsr40kFSg2WFFHzqtPsM480hUT74iEqdLac8oePxPmnb2RBfQ9JunU3eJMGWOTFJ9cOmOTsvRQKXK\r\n+cdkJXw25m4ZEjNyY9r0sJNTiLCnQAaJjrg1kHUzkJE0h+BeUjlxohWfQ5Z4X8po8K1wHSOMtREb\r\nBY+p7R0Fz5a2nOqzdOppGVXwxhoHA4lHgU4QFDxmS3kQyojw4+BDp/BdQOWTUzAuSsK+RqK98REu\r\n/BDG+Pw9SkbMBFd9WXxc4hqRJ1/J6D5WfVLwmEZ9UvAeS3n+OEmnngmkhuhArVinBNz3j/hfhJGC\r\nNzPrDLPccpNFH/TYGeg4B/sfffU26cpzFbyfxbilx+dxxRzqaJdW5brVdY0J5o16m3TlTQWvnUit\r\nc+2zlZUifb7REdFYdNtmlLycoqYQL8CMH1uAkoJnkvf2PHgEa3jo5JlvyzGsx7NGxXsczATteJ8H\r\naeht0pVXtxCKqWlVFyESWpmJVlGDKiMFrvr9Pk6AYyuQMFqsomVBx0zFmi7bi0kG+6o5OuDYSQtv\r\nrAjWFBy50KvIdEh7kNTetaUcAB2W2N0Byqn+ON43nuah4JkqnEY+qMvB0EIeWCyzLbn2hEk5gtQ2\r\nsAolkhKKg8IltWXlQpoe6gZnKnhrJJ+6Q7uE7cQ4bwXbsWngkZVFQRRJsnni30H+w9s3jbp9quAp\r\nUvdRobdJV1ZuHwJE8SbmEMhTRIYapa6RT5D5YRxMky9jRGWuFJU/pazHD5dkMjn/Xvv9pIKHNzRB\r\n60MjDxqYOzUQ/EUp2am30rMLK5PN2KsZreVJH9tC9RMx8G0VPKUUl+Qd4nfkNGfwRbyDGAyixPFT\r\n2e9ogkpkBonOUdDztRIt4WsgYqPlLD8HNAdfGfbx8rD8lOZ9rCeI4cpY1Nh3GiiGZLzXRv4rGiiO\r\nDcHueJ81ept0ZeUQ1XW0cbLa3Etjztk8zLsX6eeV2KYL1FxypaeTLT02Pt02p/NyvsKmYNquuFz7\r\n7UBsG4ijnjS3Q31OMhl6m3RlU8H7W//+/j3wN+xm/Hz919ukK38wwcdAFxgMJAqeIS+kIG4q5q9o\r\nbHNILsQ20x4VtasYdywTXy1t+wDSYFv+dfThXHQ5roSBTBlzWtjoYfFIftOCObVF0P6PzTYMK1DB\r\ny5FRcEy+kq6OneKU2te7Bln0YLWFROo98qiLdIdvCoHW1fKpx7JOQiEh7zFZqdwKlv+N2UGU3iZa\r\nY5ZOna06YmKh2llIiNT8c6jkhIBtPjGuglYjY+GzHNajgSRTrLEgTj2obA4BjHQuE3cCZwkrCPCQ\r\nAIjCETxBsJpXlkaLW5VBcWyqvBrF3TwhGqjLMRSrniiPmUeRIJtnOnW8cibQoqScuBSVAo5x0dhS\r\nUE4Ohl3jCsNgoIgYsMnhwCxUYgVyeBA/vK95CfWMmFxms4k35SiZyIbgF4nyQOKu5ImB2HOBHscT\r\nBqei3KKL5kHHui2duoKOozQNRRy0FH5tt/SAIfPYUpBOczn9iQwG4qO4aEa4kwZdWTj9TmXizsBE\r\nBBtho/KNS8sOgp94dVX8tdkFyKjCbYXj8qEn5Cz23qS+qHdiDVLdkcQMJiGjIx2JyDtQ+PrhzROs\r\nIEvquLxhssN/PX7mmObGO27smGnr3/gaP7/12n3qLNKVjxQ8w8tJ+VfrwGP9VcXfAa2P548aTQXv\r\n8Ug2QVu6X9dilvbLhv9PMXk42x6tzJe1PYpNKtq6rvzG/jpMD+bls5ip4FkkL0kfuDoq+8PjYRCa\r\nGA7CbYlyQ2vOaniehL4nkXz+I4izHaU1fL4dszcr1zNDMSb9XIkkXlJuZQeHasQu13PKNbVnr4ax\r\negdpY9E5k65aXN2YS71NurIF9aJJ4ekMUmDS3MCvQ4IlUjBx98ZpBGve+6USseoRr4Bj1yv54QiS\r\nqrAmAV1G9cOXvKCdy5EjfKEkBjgs93GoyvWcUdrF4ReQP06F/Ah15mlDBW/L9bxIBQ81M+mVsJcX\r\njhmyiDCAYTozSipt8xn1NunKEnljehgPHU4VuHiK3W3Znkl8ofEfgzcCaEWWi4FIXtXueqNQUo0O\r\noZcx/mE4lisaLopeTdElUvlyPHsHmnI9V5R/oyIUECMmPRZDzqOBhlzPUsFTFOqlCt7mP2XsZMJ5\r\nbxgoIrNCVyoeUrlYLbOzvHvJO6VzsPzPRP6Iu4aOoQ672zlj5KSc0QRJ8GUpirdq4ClOHpO2ZKlA\r\nuebZ0NpWD/mPwV4unvBrDfymSni7XM+iimrGu6U2eeW7dNGvUP1wovIKafsF9zbpykbBU9hqu5or\r\nqfO2sEnTPaq098fcxd7NyAdR8Nrl1RJEayPi1zW6nFH9xt+Br+gTsMauInaHOfGa2W3WgpAVKWvR\r\nqiI4jhseQAeNJ1hL6vIW9TbpylLBo47+qXKzTvvwoKm1I3suaTWfN8ynWe3gNst2kzeNVmf928NE\r\nAp9rHruboVVrW3z0fWPtvUKr9Dzctri3SVfWSP3zN5w0/YcPjjgYiNOrW0jxUOctPAbsD+W89t6W\r\n73cy7ENj/23Ns8Hw7e7xYtULXLHwhtVLiQsKWYTEylT4bPzWM1SsvETl25n4YuNNBc+trqxVTgqX\r\nqO/xm7BtvDPtGRra1u5pWtQ271eykTFjiAeEFKQROfwRPq3yVg0UvLbUOnHa05qMhXcaUTY0JHOo\r\nhahyvySbLDdyQlktfpVhnu6+SILEV5kHbqEg06skrYQ32Lbikjh8EtmS37aFd7q0Z0YxZFOatnVh\r\nXIpWIUQ+xO4mAnNy9RgFDxkWjT/KttQEd+cUPJDlZmJEOTE9GI6Q/LiKhcWvCJOQ0R254rRrnFyZ\r\n8F6NexCwOfeiEcirkYgNe9gWrkWXVhLaMn4UWw4vI/HMO3JXjlnSKtmFWmJZkrshRoOfkLNpwF4F\r\nj17tKXhMus4peCDrK2SUOa8w/vYhpTGXCuHOr4t4dMgpkvaDGVKyvYpTh8P31MtkKngerRGIbdu2\r\nql/WTF4Nfj9YYEGhjoirPSVvKXg2s3c3uHjKDe2kT+Td5CsR2c4ogszaxuVJwWNWliM6oeApKQeP\r\nJIibnGRTOP+N9IgzctovwmzL1td5j9/AyIB89UWeejUbXq78YDCQeVM+r94oewM1Qtj23hfs0+xZ\r\n6AyqO2lx4vfaQR4kuqqp8kfPzYU2wlZY8fEg8y4m23v1LEauRvoivhxPfPaxkdmUv1E0vOlmdyDZ\r\no+Ss2pba3wIRZk5FeQLuCgS8xsLLUTyVCGNumWShjMzimkFhxZlJjR0yP/4eEE6+oYIXWzqw0BQ/\r\nUkSiC5qOpOQC9wklpJzQtfbICsyVQJ405uC4ZVSwiLwY404HEH8Av/+pgmc3Y2hjBxU83G5bRjTH\r\n+iYtiClnwnc7KBOt5e/sE2z2NunKq0OeWFQwZnxb1ljNuxFvGlAv1qwrQ5rdfo5ABa+igscQDE8X\r\nQw1z2SmaeazfQ74k+ZGqRbVgqYTvtYSYx0y4ojKKTRbyQ/gO4p0U3sbaA+Suk78spK5qb5OujMPM\r\nfEeWhTbggGYqlO9PJD9mc20ecp419wl1269yozXRF0XFMC7ClfvqBJQKXsZvWsXjZHrdgq4lSjhW\r\nb+aR524TvlNWYAnvvdoRDg4d0dsqeHWRqKSx5hCp00fjqMWIFicpW6C6Hbo5whF4onzWivlQElp4\r\nbujOxTOFSYN8rQgro4KHLmheFtHxnNTuxrbaoPHvFHZhCXSb8N1YeQQqeAwUpe33WNrbpCs/E9Ha\r\nRMT20Vz+9lUYDfmtq7T589oGrL1aXd/FTCAWTuKj6baB2Z5bjVZt+4B2aFPie4VNBW/3i+ht0pWZ\r\nE38ezsmrGevvfdn/49Lvvaz9cfnxddxRZ5LPSPoCHwNdYDTQ+Fiq5I/but3iK7TH57o9OErDLdc1\r\nHpLdHpErGSczTrDFK/Ns9Y6WcPFGaHubQlu3enOXvcYmdT9l9x23EDXhIg1WVPIhsLm0wgLPlexL\r\njZ7n0xInXd2BeRQOMRUGiEjUrasL8RbciefliUqK15D94hS7iWcQCTKYYy1dRg+j4CHGqkS0GsXC\r\nXEfENZ1qCzY4MfCYrjuJoh0MVLK8WLgRmTNEQ9gldOZgeCF4bFw2TV0eXVc9EJ+DZcg8Hop0+GhW\r\nJjADHPzXeKaNINCZ8Sqa1ZqjnKR43VPw5PRk5EZ3mdidH/cDzP4SiHCWd2MwEIJympwkZhVLFYbP\r\nZOwiPwXeWIiUIrpdRPjigwoxcwYhRs30J8crt+jLhvLnOL8y/iFMvUSSwtQSIxHN4chHFQUPKT0S\r\n0S4SDMRKUrn2j/wwZ9AzDSHLx1NTGJsvormJ6eaUJxoanu574rPhCUBMTgOMoeke5iiHC6dmVXQ+\r\nW7ObmJtC7mFHOg2EOKlve8srMncDGgVPREEloIWPJypPZdwyVh8g4h5zj+OKhsPuPthjuGf9JrCO\r\n/HPd6U3SlWcUvOPs9nHJe3i226brfzF+3RZPHzWa286eUfYBvrtyLyZ+fDRqYMxuz0l7et7kYeqA\r\n52OgbaM9xHXlXeVZd14qnvdou9lV7m3SlTmDTFFO0bs8zZNQTJ/FvAMV0a6VT0hqIG/Xb/kBJwq6\r\n5tEiRB9nXD0x+7SLV2k3q83lxRIjM7Emh1cZfag80K323VGOD6iCtnR72Jo95AqVrEwokPXre5t0\r\nZQvJjBpGFHwwq01Xoh6bCraD7BWkGyJlWfl5zjwuCBzHnCriLOSqty1l6PdkDXvhVHSMItSLmPAX\r\nWqIPkoqmKpfh3kDi/2ncZo42yy9GUKn4ciZusucHdqhhCYFYi35hb5OujEcR1WDU5EJxTGmK0cbs\r\np4YWOKIiBmrZXuW8OzlQgpBhoDG+kPyy2iSyYPD3KmOvi6R8gGXIMKwUF/CeEdrrE0bfezPdszua\r\nBrbUuY9Owh70oujN7VPTkjI1e/v1NunKBAug8qMMFXzX8OYktVxg3jHIYwy5EgjBuFbOyjJ3nSlJ\r\nMC5TtPeU60LxLLA5OZUyUT9jmw1O3ze/TxS0ERLiKQelbtyvuey1Ep2Hv7l1B10fZppRkDGlZ7EH\r\nYdpNDYRLW41yz+7rbdKVFbPaKGkCknXKtUFbrmQixekKaI6TxvyawmhelnRCkyKSm6OFdvPSZeuV\r\nraeaOIEFXbBYQnpHqbvmi+M/bRSjPi467KokNjK02oCQ87iyt0lXbjKBu6rtOPqFT/PZ8b6JlxYZ\r\nsPW35fToaHt6Gzb1oM89K2zEQFuwLXwbvU26skbq/x//Dgsu/3qTfPASo4EQR7d4FxWey8eKlzhr\r\nYU++/QcrPWs8KrUvXyuHIJwepyu+i9l2hmUwcyB1kcue/E5E3RaPGh20POeiNVCnl/ZhjiUxkDL/\r\nFtVibEdL8KNIftD8im0Dgb3cmc0jrkU8KFEPGSYeN77swuyZWzkBHlYc155jKc660Wzv1klA7LjB\r\nkqULl+VoCzXRb1RXjICXYqiB+WTyeSkKde5kAgsuJKWj5bYLR0fif4q7NX8N/i0iUWwkIe2T5hDJ\r\nlqdXeStcYdqcSVmGqzNPUmHGWdlzGbqOa19AGRlMpy8QKwN37vANDAYSBU+jAjxJDgMxOERnxJJP\r\neAVCkA8NJ9wLA61LWoyOGAoZMciYiqI0aniMQ5WYNil0A4E9seS2w+MrcEgrMzOPUFtwDqHkZeqL\r\npLdsEYHmqQXPQKAGA3WSvUnihHnbsdJ4UkFly9lDd6tFeVy9I3CVhZptlc7JomoxvyCeOSOdrjn7\r\nNeI8Zf4SD35ebyQ59hztc1skqs3b8S/khY0ry7QPmHgRnueUDEaQFBO3i/LHjGtfgHy3zPdG6JBo\r\nOXPcY6XvbPB/B6J/f5Oe/Sbd+H2xM9DZaPy/ht4oFwY6LnkbTwdMeyjqt2VPTqfYmGGNJWbPWo+l\r\n72LiXDvi0Y++am+TrmxJIE3nruUYbKJ4b5HZ9oB815yAkadNNmU5C8V7gw0zNnmCVK7KJ6lJPbg2\r\nFfoz2XEnPoCsR1vrIf81Et5CbsrNwqf2jVDwONqe29fbpCvLYWbsGumCRGQ7jNqz7JJIvgH8Pkqe\r\nqVSmou8l5mQ59GXBVzSNrhSIBCZYkkS0PIkzF2ZTX/DcxmbVkV/MTK5uizaYSUGKo+3Bx+P/ySFI\r\nnY+D7blWvU26slTwlFLVJlVR7oWzxQJyo+42fAEMpKFSNMJhjfDSFPAKBTLVFy5Xi1lVItpGwYOV\r\nJiG+UA92ZWvSdFZcyJaIlqSqxseTE41lz5DUDlWJZBWl2zm2ept0ZSWiZRRnWXh9cXwHkjohz+7c\r\nZXkCp6ElzDYLUCV7HKM5gkaqKJnnW3MRR64S0YqCV4mW1TGXMjEQ36b0TyR2NySihTnYEmdME9Gi\r\nhKgsuWgaPhb2NunKJMO2dH0MnpR61kt++MACfQNGvlPqP8aAXNGyx6WsRZKxPAUO/5prR8Fz1Suv\r\nrDQrx9oaJqJ/txhXkJ8Mc9R0vB0M5yw/wbEt1yBp7PHfc21vk64sIrmucxY/u00ING/cbPOn2BLU\r\n0pgtKbIU+T+7JU2+yh6aKCIhcLu2tnzg06usbkDbpfhxg0FRSfu2tywf5eQILGp4nPTobdKVmcm0\r\n3Tx29utf7212q3tYcf3a/tsvtTn76euw4Hxm9YMjLgw0e3r+b2EwUFWchGWCJTN34qpBzsa807J7\r\nB4M+P3EJPVeHSNhWkr9ro8IJ9lzOE3yGe7fmpVHwZt4M+Q0Ip50wCFuHpwkeHVJ7O8ycSUND5dos\r\ny6pZJl8KSrIcCukklJ88B+4WRxbTAdGv3KkFAg4RvCP0EmUTlMiIsFAWiFxUEVGzzWiVlX5Nfmnp\r\nE0j6miP8tnE3HQUvxwVvHHfPdtvFIQNNP6KCJ9W9HjDDqMy4ndus4kD3VSYGYrBaGHsxsMNJhcsr\r\nyqlkqVaVvWLmmxwQPekhvEZ3zFffkvOed6Ib0GkxkWNSoiqKNQbYbbZdxvCZIM4sCl6ExskwEw3l\r\nIxxpD5i17VTwLGdFp4Kn8e/QkGgLG0oyfLUR5eGaMhypnEYIzXiTvvOescsaFaFscnKa7j5s5whl\r\nq0CkO+Lxg4SQvFNqDFNqXKJiReuqwF+ldyBzMSAMAQOTZUIB4xl3pOU3PqKp4DEJT1JahVlDcWgq\r\neMgoe+x/cH/eQqUGllQuNEKMDwd2PBVMvI4VlKyKZMEWsdzsVjg2+sXwSoC9oAXaBCBtl7NLENcS\r\nbszkouWTM8cs5DvrfpuoOer46eavbTOU0oTO8cDGRh8M2Btoo9L819GbpCvPKHg/Dw3kW2G2+DfG\r\n+aPG8Vnl54H3xR5wzA3TnnZIUnD+VPWboLdJV/6lBuIGwZRRrako80X0cFcc9xtSXkweHH8f9Dbp\r\nyr/SQAzwSKNA1lBCGZojq6D9xv0XZd/f9yzqbdKVH7l9OnRuAJV2a8WEnR8mKd6Z1Q2o++GVRGUu\r\nEfbKwE1BFBPBtg32TK2dG3nK7sSbD+ZQuSsfNmpNz6HNDjqZvU26MuQEpjAfIM9M2RI2S1ty8c1H\r\n1JbkQmyQfdoDwgFkPvim8keRM1jO7arkr3BdhyZPaNDIhGdEbbIlfSZWBPfrkCt6JzSJQ/fZP73j\r\nwif8/9hFofpF0uDvslyJOUH8xiT6Yk1ZnFyG1cj/SA8RX7P6GhYfRByAVDger3rnxeLruqtztC04\r\nAy5X49rGtMppT6oT+eCLS3VwLSM0abRYWAxYXsmlGT1TJHqJBw3Yu32zDTWQNIZMN931pbdJV5YS\r\nJxwCCwvnQlGR7ZE/1+KgXCNjQrLFr+yUjUbM2PGSUuVKlNjFZoz6Hrlbao4by7WK5cr3pYzIYhns\r\nN0KfpDMZsjNSrmlk6jdNYm9NRChcatfOkL/HckUjqKBMynMk0XSmJ68YMhFWmReyXN48xdTY+NLQ\r\nMPa7J7Q7wc/OPJGjHbE4SAlHn/IBD5Zrisp9pIdCGuvhqvrhDDIxVZ7BkBfSHAZ9E1dX6ST5DpUn\r\ncmYgY7kOmYN6m3Tl512sOpj13KUlIwlF1gimtk0m28SGNQLsQ4ywg2bDQgx+kRqo8k1HB3XmnXOI\r\neHfGBHiWq8uN2dq6MP44N8nKRsati37t+miCHtbqdGBhxNndRnubdOV+6lnBIc8PzxW2YPg8Qw4o\r\nvXIems5r8MmhjXvY2ARbf5stLmz6xga/id4mXbkfB/3VnRKr4XwtxTSyknI+ODHLxqq/IXqbdOVf\r\nOVBsp8E2p9LdwH7pPv4m9Dbpyr/2YfVfjFMDfdwdDb1JuvIHE3wMdIGPgS7wMdAFPga6wMdAF/gY\r\n6AIfA+1xsMdhwX8JvahS04OKK4nMOvynDVQhYdub0lxCcHyYquG/bSBIMX6BVyqRHdifHwN1cMsq\r\nJiy5BSFG5AxbYh9S9Z82kODykdLR4WOgC3wMdIGPgS7wMdAFPga6wMdAF/gY6AIfA13gY6ALfAx0\r\ngY+BLvB/S0wDKYVDtXoAAAAASUVORK5CYII=");
            this.ReportName = "Selecting Country";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.HundredthsOfInch;
            this.ReportVersion = "2025.1.2.0";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.Culture = null;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "366bfdc35bcf48f3aeb38f2b5f58db21";
            this.Page1.Name = "Page1";
            this.Page1.PaperSize = System.Drawing.Printing.PaperKind.A4;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageFooterBand1
            // 
            this.PageFooterBand1 = new Stimulsoft.Report.Components.StiPageFooterBand();
            this.PageFooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1071, 749, 20);
            this.PageFooterBand1.Guid = "f4ce1014c0454279ba99a4e6a633b36f";
            this.PageFooterBand1.Name = "PageFooterBand1";
            this.PageFooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.PageFooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 749, 20);
            this.Text6.ComponentStyle = "Footer1";
            this.Text6.Guid = "a195cb499e0b4bdcb84079abedbb3207";
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 58, 78, 94), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 166, 166, 166));
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.PageFooterBand1.Interaction = null;
            // 
            // ReportTitleBand2
            // 
            this.ReportTitleBand2 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 20, 749, 80);
            this.ReportTitleBand2.Guid = "dc71e6748bb24f168226833c75cee439";
            this.ReportTitleBand2.Name = "ReportTitleBand2";
            this.ReportTitleBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.ReportTitleBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.CanGrow = true;
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(570, 0, 179, 40);
            this.Text20.ComponentStyle = "Header1";
            this.Text20.Guid = "156dc5f28b8946c6828989624919731d";
            this.Text20.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Type = Stimulsoft.Report.Components.StiSystemTextType.SystemVariables;
            this.Text20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text20.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 3, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.CanGrow = true;
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 570, 40);
            this.Text23.ComponentStyle = "Header1";
            this.Text23.Guid = "7123692fb8e94f07b593c2c773f9f7e5";
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Type = Stimulsoft.Report.Components.StiSystemTextType.SystemVariables;
            this.Text23.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text23.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text23.Indicator = null;
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(2, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.CanGrow = true;
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 40, 570, 20);
            this.Text17.ComponentStyle = "Footer1";
            this.Text17.Guid = "08478f239a3c433e8e935725529a41a4";
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 58, 78, 94), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(6, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 166, 166, 166));
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.CanGrow = true;
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(570, 40, 179, 20);
            this.Text18.ComponentStyle = "Footer1";
            this.Text18.Guid = "40b462fd71d64adba7ae41f775066020";
            this.Text18.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 58, 78, 94), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 4, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 166, 166, 166));
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.ReportTitleBand2.Interaction = null;
            // 
            // HeaderBand1
            // 
            this.HeaderBand1 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 140, 749, 40);
            this.HeaderBand1.Name = "HeaderBand1";
            this.HeaderBand1.PrintIfEmpty = true;
            this.HeaderBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(210, 0, 170, 40);
            this.Text11.ComponentStyle = "Header2";
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Left | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 179, 135));
            this.Text11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text11.Indicator = null;
            this.Text11.Interaction = null;
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 210, 40);
            this.Text10.ComponentStyle = "Header2";
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Right, System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 179, 135));
            this.Text10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text10.Indicator = null;
            this.Text10.Interaction = null;
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(380, 0, 130, 40);
            this.Text12.ComponentStyle = "Header2";
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text12.Name = "Text12";
            this.Text12.ShiftMode = (Stimulsoft.Report.Components.StiShiftMode.DecreasingSize | Stimulsoft.Report.Components.StiShiftMode.OnlyInWidthOfComponent);
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Left | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 179, 135));
            this.Text12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(510, 0, 150, 40);
            this.Text13.ComponentStyle = "Header2";
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Left | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 179, 135));
            this.Text13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text13.Indicator = null;
            this.Text13.Interaction = null;
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(660, 0, 89, 40);
            this.Text9.ComponentStyle = "Header2";
            this.Text9.Guid = "25f1f4322b0b4ee28b083c644b29a683";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Left, System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 179, 135));
            this.Text9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderBand1.Interaction = null;
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 220, 749, 20);
            this.DataBand1.DataSourceName = "Customers";
            this.DataBand1.EvenStyle = "Data2";
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new string[0];
            this.DataBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.DataBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand1.BusinessObjectGuid = null;
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.CanGrow = true;
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(380, 0, 130, 20);
            this.Text4.ComponentStyle = "Data1";
            this.Text4.GrowToHeight = true;
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 182, 182, 182), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text4.Indicator = null;
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(3, 3, 3, 3);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.Character);
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.CanGrow = true;
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(510, 0, 150, 20);
            this.Text3.ComponentStyle = "Data1";
            this.Text3.GrowToHeight = true;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 182, 182, 182), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text3.Indicator = null;
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(3, 3, 3, 3);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.Character);
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.CanGrow = true;
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 210, 20);
            this.Text1.ComponentStyle = "Data1";
            this.Text1.GrowToHeight = true;
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 182, 182, 182), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(3, 3, 3, 3);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.Character);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.CanGrow = true;
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(210, 0, 170, 20);
            this.Text2.ComponentStyle = "Data1";
            this.Text2.GrowToHeight = true;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 182, 182, 182), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(3, 3, 3, 3);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.Character);
            // 
            // Text14
            // 
            this.Text14 = new Stimulsoft.Report.Components.StiText();
            this.Text14.CanGrow = true;
            this.Text14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(660, 0, 89, 20);
            this.Text14.ComponentStyle = "Data1";
            this.Text14.GrowToHeight = true;
            this.Text14.Guid = "10940acebff64115806c153cff3886ba";
            this.Text14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text14.Name = "Text14";
            this.Text14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text14__GetValue);
            this.Text14.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text14.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 182, 182, 182), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text14.Indicator = null;
            this.Text14.Interaction = null;
            this.Text14.Margins = new Stimulsoft.Report.Components.StiMargins(3, 3, 3, 3);
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.Character);
            this.DataBand1.DataRelationName = null;
            this.DataBand1.Interaction = null;
            // 
            // FooterBand1
            // 
            this.FooterBand1 = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 280, 749, 10);
            this.FooterBand1.ComponentStyle = "Footer1";
            this.FooterBand1.Name = "FooterBand1";
            this.FooterBand1.PrintIfEmpty = true;
            this.FooterBand1.PrintOnAllPages = true;
            this.FooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 58, 78, 94), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.FooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.FooterBand1.Interaction = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(39, 39, 39, 39);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Bold);
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            // 
            // StyleHeader1
            // 
            this.StyleHeader1 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader1.Name = "Header1";
            this.StyleHeader1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 166, 166, 166), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleHeader1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleHeader1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.StyleHeader1.Image = null;
            this.StyleHeader1.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleHeader1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            // 
            // StyleHeader2
            // 
            this.StyleHeader2 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader2.AllowUseBorderFormatting = false;
            this.StyleHeader2.AllowUseBorderSides = false;
            this.StyleHeader2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader2.Name = "Header2";
            this.StyleHeader2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader2.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Left | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleHeader2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 179, 135));
            this.StyleHeader2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.StyleHeader2.Image = null;
            this.StyleHeader2.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleHeader2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            // 
            // StyleData1
            // 
            this.StyleData1 = new Stimulsoft.Report.StiStyle();
            this.StyleData1.Name = "Data1";
            this.StyleData1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleData1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 182, 182, 182), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleData1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleData1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.StyleData1.Image = null;
            this.StyleData1.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleData1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            // 
            // StyleData2
            // 
            this.StyleData2 = new Stimulsoft.Report.StiStyle();
            this.StyleData2.Name = "Data2";
            this.StyleData2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 255, 255, 255), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleData2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 240, 242, 246));
            this.StyleData2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.StyleData2.Image = null;
            this.StyleData2.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleData2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 64, 64, 64));
            // 
            // StyleFooter1
            // 
            this.StyleFooter1 = new Stimulsoft.Report.StiStyle();
            this.StyleFooter1.AllowUseBorderSides = false;
            this.StyleFooter1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.StyleFooter1.Name = "Footer1";
            this.StyleFooter1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleFooter1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 58, 78, 94), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleFooter1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleFooter1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.StyleFooter1.Image = null;
            this.StyleFooter1.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleFooter1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 166, 166, 166));
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.PageFooterBand1.Page = this.Page1;
            this.PageFooterBand1.Parent = this.Page1;
            this.Text6.Page = this.Page1;
            this.Text6.Parent = this.PageFooterBand1;
            this.ReportTitleBand2.Page = this.Page1;
            this.ReportTitleBand2.Parent = this.Page1;
            this.Text20.Page = this.Page1;
            this.Text20.Parent = this.ReportTitleBand2;
            this.Text23.Page = this.Page1;
            this.Text23.Parent = this.ReportTitleBand2;
            this.Text17.Page = this.Page1;
            this.Text17.Parent = this.ReportTitleBand2;
            this.Text18.Page = this.Page1;
            this.Text18.Parent = this.ReportTitleBand2;
            this.HeaderBand1.Page = this.Page1;
            this.HeaderBand1.Parent = this.Page1;
            this.Text11.Page = this.Page1;
            this.Text11.Parent = this.HeaderBand1;
            this.Text10.Page = this.Page1;
            this.Text10.Parent = this.HeaderBand1;
            this.Text12.Page = this.Page1;
            this.Text12.Parent = this.HeaderBand1;
            this.Text13.Page = this.Page1;
            this.Text13.Parent = this.HeaderBand1;
            this.Text9.Page = this.Page1;
            this.Text9.Parent = this.HeaderBand1;
            this.DataBand1.Page = this.Page1;
            this.DataBand1.Parent = this.Page1;
            this.Text4.Page = this.Page1;
            this.Text4.Parent = this.DataBand1;
            this.Text3.Page = this.Page1;
            this.Text3.Parent = this.DataBand1;
            this.Text1.Page = this.Page1;
            this.Text1.Parent = this.DataBand1;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.DataBand1;
            this.Text14.Page = this.Page1;
            this.Text14.Parent = this.DataBand1;
            this.FooterBand1.Page = this.Page1;
            this.FooterBand1.Parent = this.Page1;
            this.EndRender += new System.EventHandler(this.Selecting_CountryWordsToEnd__EndRender);
            this.EndRender += new System.EventHandler(this.CheckEndRenderRuntimes__EndRender);
            // 
            // Add to PageFooterBand1.Components
            // 
            this.PageFooterBand1.Components.Clear();
            this.PageFooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text6});
            // 
            // Add to ReportTitleBand2.Components
            // 
            this.ReportTitleBand2.Components.Clear();
            this.ReportTitleBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text20,
                        this.Text23,
                        this.Text17,
                        this.Text18});
            // 
            // Add to HeaderBand1.Components
            // 
            this.HeaderBand1.Components.Clear();
            this.HeaderBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text11,
                        this.Text10,
                        this.Text12,
                        this.Text13,
                        this.Text9});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text4,
                        this.Text3,
                        this.Text1,
                        this.Text2,
                        this.Text14});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageFooterBand1,
                        this.ReportTitleBand2,
                        this.HeaderBand1,
                        this.DataBand1,
                        this.FooterBand1});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1});
            // 
            // Add to Styles
            // 
            this.Styles.Clear();
            this.Styles.AddRange(new Stimulsoft.Report.StiBaseStyle[] {
                        this.StyleHeader1,
                        this.StyleHeader2,
                        this.StyleData1,
                        this.StyleData2,
                        this.StyleFooter1});
            this.Customers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", "Address", "Address", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", "City", "City", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", "CompanyName", "CompanyName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactName", "ContactName", "ContactName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactTitle", "ContactTitle", "ContactTitle", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", "Country", "Country", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Fax", "Fax", "Fax", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", "Phone", "Phone", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", "PostalCode", "PostalCode", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", "Region", "Region", typeof(string), null)});
            this.DataSources.Add(this.Customers);
            this.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiXmlDatabase("Demo", "", "resource://SelectingCountry", "", Stimulsoft.Report.StiXmlType.AdoNetXml, Stimulsoft.Report.Dictionary.StiColumnTypeProcessing.LeaveUnprocessed));
        }
        
        // CheckerInfo: *None* *DataSources*
        #region DataSource Customers
        public class CustomersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public CustomersDataSource() : 
                    base("Demo.Customers", "Customers", "Customers", "a05d3331fc534314894c834170086879")
            {
            }
            
            public virtual string Address
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Address"], typeof(string), true)));
                }
            }
            
            public virtual string City
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["City"], typeof(string), true)));
                }
            }
            
            public virtual string CompanyName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CompanyName"], typeof(string), true)));
                }
            }
            
            public virtual string ContactName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ContactName"], typeof(string), true)));
                }
            }
            
            public virtual string ContactTitle
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ContactTitle"], typeof(string), true)));
                }
            }
            
            public virtual string Country
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Country"], typeof(string), true)));
                }
            }
            
            public virtual string CustomerID
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerID"], typeof(string), true)));
                }
            }
            
            public virtual string Fax
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Fax"], typeof(string), true)));
                }
            }
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
            
            public virtual string PostalCode
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PostalCode"], typeof(string), true)));
                }
            }
            
            public virtual string Region
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Region"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource Customers
        #endregion StiReport Designer generated code - do not modify
    }
}