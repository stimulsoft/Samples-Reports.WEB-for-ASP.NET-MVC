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
        public string SelectedCountry;
        public bool AllCountries;
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
        public Stimulsoft.Report.StiStyle StyleHeader2;
        public Stimulsoft.Report.StiStyle StyleHeader3;
        public Stimulsoft.Report.StiStyle StyleData1;
        public Stimulsoft.Report.StiStyle StyleData2;
        public Stimulsoft.Report.StiStyle StyleFooter2;
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
            e.Value = "Stimulsoft";
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text23
            e.Value = "Selecting Country";
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
        
        public void StiParametersSelectingCountryReportWordsToEnd__EndRender(object sender, System.EventArgs e)
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
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "SelectedCountry", "Selected country only", "", typeof(string), "", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true, new Stimulsoft.Report.Dictionary.StiDialogInfo(Stimulsoft.Report.Dictionary.StiDateTimeType.Date, "", false, "Customers.Country", "", "", Stimulsoft.Report.Dictionary.StiVariableSortDirection.Asc, Stimulsoft.Report.Dictionary.StiVariableSortField.Label), null, false, Stimulsoft.Report.Dictionary.StiSelectionMode.FromVariable));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "AllCountries", "All countries", "", typeof(bool), "true", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true, new Stimulsoft.Report.Dictionary.StiDialogInfo(Stimulsoft.Report.Dictionary.StiDateTimeType.Date, "", true, new string[0], new string[0], null), null, false, Stimulsoft.Report.Dictionary.StiSelectionMode.FromVariable));
            this.Dictionary.Resources.Add(new Stimulsoft.Report.Dictionary.StiResource("SelectingCountry", "SelectingCountry", Stimulsoft.Report.Dictionary.StiResourceType.Xml, Stimulsoft.Base.Helpers.StiPacker.UnpackFromString("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"), false));
            this.NeedsCompiling = false;
            // 
            // Variables init
            // 
            // CheckerInfo: Value SelectedCountry
            this.SelectedCountry = "";
            // CheckerInfo: Value AllCountries
            this.AllCountries = true;
            this.CalculationMode = Stimulsoft.Report.StiCalculationMode.Interpretation;
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Key = "264a8493958a4d8f9c334051df6dd5a2";
            this.PreviewMode = Stimulsoft.Report.StiPreviewMode.StandardAndDotMatrix;
            this.PreviewSettings = 25149439;
            this.ReferencedAssemblies = new string[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "StiParametersSelectingCountryReport";
            this.ReportAuthor = "Stimulsoft";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2021, 7, 6, 15, 5, 31, 26);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportDescription = "Showing data only by selected countries.";
            this.ReportFile = "D:\\ParametersSelectingCountry.mrt";
            this.ReportGuid = "3e70b228345c4d84b039af4d53cbab1b";
            this.ReportImage = StiImageConverter.StringToImage("iVBORw0KGgoAAAANSUhEUgAAASAAAAGWCAMAAADvzq7aAAAABGdBTUEAALGPC/xhBQAAAYBQTFRF\r\nS7asuMbHqra33/Hx8vr5paqp6fb1+v390d7i4fPx5/X17/n52+3snaen9PT0yOjltb7B7Oztk5WV\r\n1OTj/f7+4/b1uMK+29vcvLu84vXzzN3dsby8w8PD0+HeytTS5OTkw8zM0tPTw9LT4t3YzMvMyc3S\r\nyNLMs7S00s3IjtHL7fj35uLd1dre6e7y3OHk19LN3PDuxsG9wr271ers9PHupa+x8e3p2+rmvtLW\r\n5ert5fXz4vLu5/v6+vr6/Pn2ysXCu83Q5fj2ZcG49Pb5y9jVqbKw09ba+fbzsbm26ubiw8bKwcrF\r\n2tbS3tnVtrKu4ubq7enmzcnFsK2qw9bZubWztLe60ubpzdPZ2e/w3ePpxtnd/v36e8rDlp6gvLm3\r\n0dzWveblteHb/fv5p9zY7vP3+fv9maGgsMHFure5v7/C1+jmpaOioJ2bQLKnsK+xyMfIoNTL4O3n\r\n2NfY9/j44vf3z8/PzO/v39/g5PPwn6Cj3vP1+/376Ojo7/Dx4PLx////sAAiywAAABl0RVh0U29m\r\ndHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAIa5SURBVHhe7V2JQ+JI1t+Ezii7hAEDIQf36Q7K\r\nHfBAgZUAAh6goA0j7joKBnthFVm6bTD/+lcVUAEV7Zm9v/41bZJKHa9+qVRSL1Xv/U78jpn4TtAb\r\n+E7QG/hO0Bv4TtAb+E7QG/hO0Bv4TtAb+E7QG/hO0Bv4TtAb+E7QG/hO0Bv4TtAb+E7QG/hO0Bv4\r\nTtAbmCYobFqdG+65XcvDnUeED/dGe+NQm9Sa0e5/Iqr7poEk305pSwoYQ9j1cbQnYbPQel7BSYI2\r\nA58+LSwN9/ML47Gr3iVx+8vo1BhCuwsLCxPFPGC7fTHa+3ciXFz4dHKebq+Ki1fTF1zcXjga7Uko\r\nLJRWQ+3B6Gi" +
"ESYJsC9mBSS2KHSVgHBKklFhPKzXbC6qOZjBXVWo2OyDkTKlRboDtZvHE0b8BJadB\r\nCo2yA1NuKMX0hrhxeLKsSXeqHZgFzO/fA//C0qC3lV9IbWwMRpJtAoHSW+JX5dz+QgpWETQwKH5n\r\nF986W1zwwHo9YZqgEiTQe/VFNQcIqsa+fDGL6cCnk6PdT59U+588+5+oK9COtrEvrk8gc5DAAdPB\r\nllfaSn8yi7EvF94vgU/Ycv7Tpy+ru61iNlY/rxZVMNa/A7EFc0cMf/r0KeX9suX9InzhuldfUuIu\r\nL7o/fQwvLKV3r76sDsUvLHzCLJ8+nUzeJpMEnfkXToSL7QXH9sKSbWE5v+DZWViNLRz1Vt2fVMrt\r\nBc/+Qkn3iftaxHt+qXkWhvdhbCFl+6RKf8qK/pML70I2v5DtHH7Z2yieZFe3F+bDC/Mw1r8DoAv4\r\ncgTaxdFW4WTLu2D2LnC6K05T5MC1BQTNexdS6g0g/g4Qf/fLaqewkIJ3yBOmO+ntwwWHd6Hl+uSw\r\nLaz6T1ytT6kiCsJDoHVIBM2Lu1wYHIQlghaHVQfliYcYDI6dfPAunJ99Uon+L3PVIg96r6Jq8cu/\r\nsTuyFRf23KCbhASd/ARb+SE+BwQGYYCg/asv+i0o/i4u1nAN6HmneqpJgsLL4v6CAO5YpXoLtp2T\r\nj0p1p4hvaTZCoHVIBC0BgkKfVJodiaD9T9jqhnrr8MvWWZFXfkI0NdCCTs43AUGBk5+qxRKIs/jl\r\nKivl/u9Af0v0Lsy7wXWUCDqHFxoQtIvP5SFBKU3au+Cogc7nigfhFyDy1BNnkqD8wtWnk4/pqy+H\r\nLUhQ+BPmcmlsn75cHVWvFrLgZgG3nljENf4FDBs+ARYXFr4s7G1/uro68VR3F1pXJx8WFySCFhdw\r\n9RW4NGL66mQVRv23IHBy9Qk/D4OeZXHhD0Cy0EJW3K1rCrACHtAH5VuHnzxD8cVd0NDdC58mu4NJ\r\ngtI39i58JFnaOk3Yfi6Gu" +
"3ZA6L4d7to9afsy+In5lKjZSeVHrwP7XfvSBowIHn6hbs/dndu2d6pd\r\nj3iWd2zlpThF7t/3ohSy2FPgqeVuL293L4Bkm909cceiOctb+vZzUJuQ3Q560aH4IBzckaCG45ju\r\ng96HHV2viH8YHbyBfuHhzeq/EpMEDdTvQ2BhAV8a7b+F2kJptPdfgsl3tgmCND3dO3Fz03t/3HfH\r\n/CdhQtRX5X4M74/YGGLqFhtsPL4FPL1Qnk0+pKvS2/XY20J6rIupTr6HAjwL+JdDOT56mDgAh6Mt\r\nfLdOX4hVsTr10j9J0I4nZFGDPDY2OhuDrbBSVIPsQjf9UMe2B3NOqzUhdSh1cbaRtqg7cxsajfpC\r\nubVzHupU1dtLXwdieuejeKbWhJVnFxsddSe/GlJvpZVV9WgA/G9BtdtLdQYbli3l1pYm3e0tVQea\r\nTXV18DU0GHR29jrgMLSl2b8x3dwM2uc63eQjd5KgfZ2yC+6InqXX7d3oUuA+6s6lb/L9nW7+43Z2\r\n6wycs9zoLJ7e1ma3ZzHp5vYtajtIYbfo+u6Urg3up4/izt42aK6D3s2NzmuygxTdm9S/k6AznWjr\r\nL+q6Jnt3MJf2iDs39qUb9U5bZ7GkdHkgpl0HntKgezl3b9kGOotulG6ISYLS7pQn3PXsgxofuW/U\r\ntu6yZS7cc9/k7T3TTXt5MxW2eMDPlhLTqX2P1wNeCCyWvs6S6lu2wjqvZ1vn9oiWjnvVnTLd6JQ3\r\nun4v1O32B93Vr6MS/g04swxudN2Urtftb2jSKUBBr5/agLXcBqKr83bPvk6self3PbqLnfN0/o0W\r\nNEgrtz2avlINXqYHIZ1dozH1BiaT0rTd64j7vc4grT5374nVXm8uD26pntKkHih74LdlGvQ2+rpz\r\nMdTr9FY3enuDziDUB3/6/ZBJLfVb/yb0dFuhHnhAA0nnqjrdRrrX2TeFesqBUjnY153DPRGEb7lX\r\nxfDFvmnypW2qk55CeuqGHOJMJ90xoZ5" +
"09D+O2QR9x3eC3sJ3gt7Ad4LewHeC3sB3gt7AJEG+H/9R\r\nCP6WrILHo513QDbafgOOZ2f/+xEZQ0wS9PNf/1H40x9HO78Gf/oGOf74p9HO+/Hz7Oz/MiJjiEmC\r\n/vjX3/2DAAga7f0K/Pz+xICg0d67AQka7b6E/wKC/voNBP3u2wn63X89QaAGo5238de//ZoWNNp7\r\nEb+WoG+UYwZBf/oT/M3AdAuameB5C3oMeMhkWpJhC/rrRJ5PcX4dQX86/hGce+3sC3iZoL9HQB7H\r\nP//152vp8LX8Ji/xn+7+/pe/vybZsxY0Jukv8BTYk7ZPGLWgXxR/kQ4h/vq7sf1fQ9Bf//yXv/7u\r\nl+Af//bjj3/+y88//vjzLz/+/Ocff/nl519ea60vEvSn4/U//fyj8ue/HBO//PjHP//ljz/+8S9/\r\nnqogwFQL+tPd335fvv7zn/4Mi/0L2EykmGpBf/37L6C2P0JJ/6j5GxDzjz/+5evfJmWBLeivP//w\r\np9/9/OOff/7Lz7/88uOf/1YFWYMDkNmvI+jvf/vrn374+f7vv/h+Cf7y4y+Rv9B/8f3t+m/HwVGE\r\nZ3iJoL/+Iqd/+fsf//6X5h+bP/7tz4q//+XzL38PPidougVFf/z5x1/+/mfmj+Xjvyl+XP/7eB87\r\n3YKgpD9//ln2I2h0vp//TP/4+U9/+jwVBWYPCPrdX4//9meC+GP5x1+OQdzEn35R/AhP/6pb7Oe1\r\nP4Nr8pc/g2v+4y+fj3+58/0l+HPzT9GD1xK82IL+/rc/Bv8cXPvb8d9//PMff/78lz/eEX/+6TlB\r\n0y3I97u/gmL/ePz3v/395x//tj7Z5qb7ICjp33/8y1/+9uef//7ne9kvoN0dv9CCgDDNX34JKv54\r\nfMyAWv1898vx7343ByP+yk4a9migr4Q94C+gjf8JAPxZe/WB+fItJuUxSv2Qx+jcOKYeMw9FS3+m\r\nUjx/iklZj2LC/Z+ny3h4isH8/gS6ariFcX8H77pfT" +
"dATnq7vX//4t+HOC3i5k34f/l3vQb/8Ef79\r\nzQSBLEbb8b1p/BaCplvQLPwj34P+Kon8DyDoPfhXtaD/1qEGHKyOdr8db9RgAv9ign5/7PsHQf7D\r\nr8/qmH6/HMc/3I/23o3jtbVZ2R//YUTGEJMEfcczTBOkEdMX4eHEhA6cs7AxnIU9hFJz9g3zedNb\r\nT1MDAIYziuGU4I3B258RQdoLsQPLVoqajjhQgt2NLTiL9xnO4HQEeB4iNPnZbwyTkxYAquNVexXT\r\nBO2ee+2t8w6QKR1bBTLWhC2NxtbzLp9tiGnhPKTeUC6eg/234S5d9vQDsdoB9UyLoq20ZN8CnFd3\r\nj/YD2FuieV2eHaFfEzSizZVadPX0VxeL5v3anrc0OJyajpWuZS+U4iX4v7kl2lrCnFIEl3FjY2MO\r\ncJsWq8qqvaPUeD/CL6YS4yOEKGEZCreh3OgAfqtKjUZ84QP5FEHbl0s7VKsm+DGLvth2nYuHS/mP\r\n3l3V1VHNZXcFBIv9UHeVqnHno/gzUPuwSbmobgzrFrtFQcwLyk9dDBC2mxK3Jya4v4AzIYTsC+3V\r\n2N5AUBaz245NR3r3KE3tiYHB4lTitGtvc9est2NZlweU0rZcmWsUKPOwFDDbsCxV6n5aDWSL2YDD\r\nZi+qnhiKrbr7gVa75Xe1SoOAoC8JRzvPVyJMExTAuIK9q+9fdQOexVTNI+6mFpf0bU/Bgln8e4f4\r\nvmA36/NY9x2f2mvLYUEVKmLdxSO/KiVWd0rCDpx1nj5cjr3F7xm1nd2nBE9MpxP6u1nbkXfV/4lT\r\n+lOLgAPrKNIImtBhu8b5r7I3BbO4c6Xfzd6oQodZG2bJC0VVXnALeneNK+gCMTZQsowSAcQ8Bb7Y\r\n1XsKuqzXHsBUfVWs9MJs5UmCzuziTrunu+kUzOEA1Qt8FC1i6FLYNuctsZR7Wdft3iwe5VOxo3fc\r\nvfuX1MB/+XHRsf1xH1x69+XSYnfPdK4pZDtjYr6CnVK/0FbXQGN" +
"xu1a91Fb+ouNO7ehNLWHL7RnF\r\nGWEzkM3XzDc3grrgEN3LO3ZBXaR6S+nAkk3QUf0bNSiXytraKbcjRI2lTQcuPYuO3qqtr3PfBPSp\r\n8JIXGZ0ax3Qf9L+As/Zo59tw5n+pYU8SNPe/gYvR9tuwsaWRtpN3xyRBa/f/E5CPtt8G+TCZ7IcR\r\nGUNME5R4yDwRpYc7NC3taBOj40fIpQD6SZqpgGGCYerRdhQjoYUbCHA8Oj+2A0CDOLRcRifk2oRc\r\nik5rtQnwGx5MAISP9r4RdEKm1cpGB4+YTRBtDoLy6AQtR7iDqFa+xsw7EWs0QWuN/Hw0kaDBD5xN\r\nALoSkRUQHjUHYahcTtPa5kqUTkRz5WFN18AZWhs9rUQT4Eja0k0kmpDTRCY+zCmhjUSYCLgCdOK6\r\nkpi/A0FS0nu6yajizLHWgJadrIJE7u61hoqTXzEjCvJgnEgA7Sm6Agp6kGzq7AzQhpXoKayD9nMS\r\n1geKCTCToN9H8IqBXWmqytpT3Mham0ljkuSRJBuMuuIRklQxTpY5RQi2QjJJjD0F8tbnybihcdxk\r\nDGUPjihyB66KdKPKr/GVZCRpxlfMcfqeNuNxJ0Ib0NOGb52vBJMokWOJXPIk7lxYIZgmaa0kcRA0\r\nIjdBWvGgMx4lUS0Wj9TnQdPBUHkmrnChDTQ4cQfRTY5AEcJqMLOMoWFgmXc3p0RuIXGFGpAkYzww\r\nqAgVEBNiJkFRso7mGrz1UyN63SAbGUMGRVmUbxjZqIs75fhGhqvw5pMM6sI51MiaTzgrix6QPHd8\r\njbJlD09idR6dB5cSFl/nEJZH9Ai5cJc4beT4Oh40oM6FShP9sM6d8hySwSq8FUXNKzl+hcBQA8+R\r\nDZAWpP7MKnKooRElMsgpD5oOEydxNJG5NSBE5iQ40Ui0ycacE0PrLIdwOJ7Bjyfom4WEEW9gLI7H\r\nF+I8HyQPMkNuZ99inJVHmQxXZ6MRNjfP8oAeFs1kVPFohjUiuQMVp0K5OrqiR" +
"xmU5cCeCiPZTBJf\r\niWa4qAFxchzDrhjm5+X3a/wKoJJBeRSrV3wGuF25M/D8ycoPfMOKkmwjyerRDNlAczynYpN8BgY1\r\nooZ5hqDX2LKRTyLRJtkg0JVTruxzYvgpsn6CBM3s5E1EX3MIb6hnUJIBnBsboxvlHUg4kTrCcvEk\r\njqBoHGHRYfOdSdA6EVUYFE0iGaRlzYgvcmBEg01CQRyAjsM8H4woIvyKz1BpBtetwaY1aKj4ksx9\r\nstys3NOZlYSvGVEk5yMEACiHSICMtKcVEEQo6NMD3ykj9zUNFQV9bS5HrL6mopkMNpkgUT4FeRiC\r\nUlCQBombcq3Ragya57WE9R6ctBI06PEVCoXMaG0aFVNNhI6Yy2tEBAjXjFgVzXc3oHt5BGQZbB6A\r\n+jUVVp8RlALxRicNnh+gvwVdHfgrp6NJRmrz4NkGwkDIGgM6Yy3YkXpErVYOftJuxColAZ2lBFAQ\r\nzIq+B5HBTw4eNSAqiAG291IKOcgebGH8YR7DIJgIpJbLErQPHMBU4CSsDjwJO/ZhNcYAg2AqSe5n\r\nZ2cAJpLSwL/DUgBmEiS9KI3jWdCr75L/Ky+Zs18Uv+MZpgka1/RImihxQ/NsCU+oP6l9elE9BNKd\r\nPS7RUE6MkwcdjVojakTl6+q3jcEA5Frtdzb7mtAykEUtVgdiaEtUPx9x93/lSpDqV1EzFP2ZMu0J\r\nUwRVi6vVcMfrAfKk1Wf9s74oLqLirnVTLSo7yosztaYKgmyfHGog8sbGV83mljjo7b1knKKGiFfz\r\noU5+KT0QB9SycuNssAFXEoHKLl4OCo7w1Va+NLXE+BG2m9bSzqqYd50HsuniEhh7xxyLQs9GqQtj\r\nKh0JVT9FDTQXXzvqOc3gUW/5Hthw0d+oKjc06b6o1oRfTjlFkPvyKO/S72ZjQvfw0tJuC0ei94v6\r\nkwMcY91iibp0FASHKLaVRXOhRllM3cNWu0Wpiy8sa45x+wt7izzUzHT1rZti6VDQC/YWVDh" +
"UqS2v\r\neePwXPS/ttq3rXYthR0iYNCfDblSyv7XQtevF/ZLF2lqqr1sZ8V8y1uyHF5mY1f2qxd0Xq/B/Wm1\r\nmPVjdqrbLjjyAvUiQ1ME1VpYe8+v7wqhQ7ONOlSFBNGrx/Q1877L4XXdUOqWSkmJor/rusruU9m8\r\nq5WKffRnd/lR+jHY9Zhg92P6mxiG7RUuQeK+EFItClCD83EjrxIvz2OvLmaNXShdfbtY3VGd+VPp\r\nXZNOmRfSAcf+pS4w3ejC1Fasi+0Ksf4u5vB+ywJ0G6hZoNjdX9BdljSxvdiLV2uSoDOL6O4OdO5u\r\nXuj39m96eWpZdPct2yav0PekBY9ucLNDgXx0OiqV3816Lz8upkzLuhvqBR1qr28x9WJZk90u9PSC\r\nWu/RXXipVagwDbWyJr1HzIcOhddu/kVPLGVbErcpdT6rjIE2uy3subODwpGt5Zi+nfOlI43dttQD\r\nsmX3v2WBzX7f0u/lHT3djc6m7wde1gJOd9LfgBA03vFPAui3xH/rMsVHTBI0d/Et+LbY34Q5zcWF\r\n5p+Y/yxMXpdJgtaeaUf+/2H2UONeO6lLAOMH+VB/AEcB0s67oQXji/sEHF+8kBIOOWYAjlqghkYL\r\nVWwJOA6Awx1pqAF+YJAylhqUAguTMKaLewKMK4cZvQQ4QgEYHQG8MRZLHoPBCRBHGjUlCEZ7f30Q\r\nlQMRFQa54Q7KCfZHWc2E3MeAsSXtrGhHKUE6rTTukfI/RY5nZCRXlMEYllzxMZEmLTevKEjGQAZp\r\nXw5JIvGmOWiIyx7T0klEllgz+0C2WrpJVkAhUP0l6f0AsWBfBo5kPuYWFj1K9Aja4GsSTWI0UIWY\r\nSZD2ul6JxAmEMEQMSeT4FItHsQYWlyUPtAY2gSoQxhA3ItPj6RehPV0oG3gVywebmQQKKmWMy4xx\r\nQ9BgiAfNRASv+Mxx32sZJXIM1lCw6OlJk72N1MtOXJZpyBLrSbxi5hAcyeBDrRwATeCMwtzkyuam\r\nsRL" +
"NoTzYSSJBJ5OsGKwKM5GMG04IJ1FsGIkI4WSmGUq0yjmEH2k6JMwkKJrD2RyaGSqFWL7BxqN8\r\nnGPRej0YOeFxVTyDsRiLvEvn8gNaXidVjL5yDVIa6ijIppHjEBavs/XgGoLkEKz82keCz+ydsfGB\r\nnF/j71TBdRVrQONJvuIsRxpRZyUnEfRwK8nvyQaBcSxW5/FK1HzSyJygnBnFkTqOIaoTnmNZjOBx\r\nPg7k5uvc3dQ1SbiCZmRhJTo6BJhJ0A8YggFurBkUsHOKNzJIlEIaRpyz3hlQBZqJZ9B5NsmOZfc6\r\n1ngCiztZNBhBfSiK44gRayDxehxDnI2oAmoU+cprbXGNvXM21tHbdeyODa4buLKROyYbTZn+IIoe\r\nZxAOJR8vklyR5HgMR3F2nuSiOTaDswyXQxtJ/OAUx9Ake4qiJI6rkBLJIVzlWQsiG6iVx97bgtaZ\r\naDOpiCBBAmFAizTGy1rCCm5R5wGtMNDzCmSeUBia89OlvAg5o0CQphn0QfO0wZBjiGbZGAd9nCHe\r\nJGhZbkVmxg6ar+SUMFcihA+UwxCI1pdjgESniI+mDYp1BvQz8OCBWrkPOWjmmPkmQpjntc0gweQM\r\nWDw4T5srSasCdhZEMmmuEFZDk/mce3aLyX3kgYwgxsJnEkTTMtDb3yXk8LFxD/tpmRw81+Tw6wjo\r\n6+4TtBwqwmTvAn1/C/plEBmkBN3jMBuQGjyEZLJb7X0U6i1fQ1AuB+lkWoXiXnYLCgYPrnsZ6JlB\r\nIBBPOnjAraRvkyfkt0B68LRK+Ky3oAjQJ2uBwKBAmr6lgSBS2CjNE8BzVkaDwh7hm0XQhz/8K/Hh\r\nn1Xcb8r3p0m7SJMEfccz/A8TpPk6/P/bMEWQ1/WgT/E+7NjHBrn5ZfjznouhSStEL2HHNTVPBSDd\r\nHzdSuCO8Ok/ITQ28DqV/Kd3eAiN5RzXm0GgWHeL+kajxpvYfhZSwcyjpErqjMVQb3CKLcD+9Koqb\r\nQM7hoPf50Peso" +
"H+o2s5reqlnBAVaR27KRN34s+3sqmmHOgoHWjfZubSwV6CWvY6Y66jgstjtnlir\r\n73+9ehL8Rcc2ZQqkYnrd8o4lZGlb9ty64p738qM326PgVKpA8TmFQ1SFXksfm0+XQtAAqxvTdFxb\r\nYvhyrqYSt1ur+dI4zWFK6bdQOj+npjyxIzHc2gtTrRtKn1XfxIT+TUH36YjqFZY+LXkF9eU4s2Hu\r\nXNdL9XRUv4B5CsY89aJ2apogQV+k9PrYql9/6VmkUoGSWigInZCrd5kXFvHSXqy2V2h9cTu2XVmb\r\nZKX0VcSobLGkFwofY9RerE11a7qAXrdbdNhcmEClLj+IZ4L+NYXJmZAWvJgn7xH9y+DPpWYHCG+j\r\nYlhJzJeoVa8wigfhzoLGao4t+4uudmtL9GOlmNofsFCL7UvBSwmUTuiV9mu8Pg9kVk00IzfV3sX0\r\nGHW45D0sCoe6y1H4BKYI8l/a/eZeyqZ3te01lx3UTHC5i8ubAcGxfXnIU1S2UMraSxZBb2lRLxoB\r\nfkSsZPZn3Udu/W73shS+6gQcfkehSLVr+lrKu+ffEqsB6lWNUuHSs5P1YilAkEZzJuxfdec2u4Ku\r\nwIthPWjN45fmLCAIO568UCpQ/ba4SfX9er3L7unudIUjm9BeFGL21E6RjXUFfXdCr5cuUPlSbSlg\r\ndlMu+6XH3h+n/RFTBKX7YlV9cZGOlbY0IeWGZkNUd5TnIEyzUT0DAeqLqnpDo+mkB2HVjE8BEOm+\r\nBmS1sVlwXYS3xA2QRVVzpv66U/yYHnyVviacqYcxX0BVDQqu9tXw24gIEu/3NeI+6I7AUWgLdixj\r\nqPbnxAtRvQVSbMAPMF+/gp2vG2cbGxvVjQ313JnyKzy1lR5MfX7ZV4obZ0AmMTQQh5V9AVMEjZC+\r\neXMa63tnTG/qJol0z253/3GYJOiH3w/xwx8e9l7FD2/GGOKHP/w02hvipz+Mdv5TsTZrKQJ4V59U\r\nboF38Ied4V/wsi8dvwkZGGe" +
"/GBVk8Zjr6wDFgXhSDiAnOMYAOzDwWUpY0P1I6lcLBZhOOUz3HDOH\r\nGmu+Jt0EhUmVAH/oSBCMzeBRpKkF4c1mUwEGLmCQA0OlKOD3MmQEiApjPcQGgzBYw0hTQShGcV6F\r\nPELLmzIgCqi4/F6RUPjASIqO+GSK6dHmPe0D0UBkSc77JhxMSjKDIzAOg1swdrvXygkYPiYsLQNx\r\nh/UEMYF48ACEz9YHZfA4GgyCoZsciBTRGrkVbfBWoaCvca6RUFxzBFlZj8iSK9qIFk4ekStocHJY\r\n4BQSJFf2BWmFT3Ea10bg5JUm4lP46Ai+ksS421GsV6DN4ZUcQmQazXpZu0ZyBzx6SzZOWSLDjSkm\r\nJNARvnHcXOOOgSjBhBNH7yKAMlieT96kI3JZc508jtC5CgNakGJMEdnkUeIzlB9UhG7KAF2yex84\r\nMZsgvh4vMXgjboxjXIa7dXL35Emcx4ORTNSF1FkUUXEHOY7nkLoKS2IVso5wz0QeIpFpGFDUjPOs\r\n/iRXRzCUMy6Q+LE2gh9EnSuzVW7ya5TA8PjdNXePlSOn7CmKcQSG8A0z4oxPJaUj2Pw11igB6bCD\r\naA5lkXqDRxEcwTi0YQQic8jCvIu9Yl2IU4Wjj7Im2MqpwYWr8AyGc+UMmuFQxAzVcDMJ+glFUFSF\r\n4w0zkI9nEvdO7ARh60gwgsozdTSHovwCkTkB9W5YMwjJniAkQh68qBcEBOXiSQwxcLkGxuZQBZ9j\r\nc7B2ETyIvjFPTr6OMhioKluOtspOM5vEEbJ+gnOA6NwzbuURTMXjpRPWSjai5hMWY82AXtZZj5tR\r\nHIicRNkkh5NWHlDAxe9GqSBBJF6PZ1ZIayNHoifSlDko1+wWROLWHMnFQTvJrDjLiSQXz4F2jdxd\r\nY1zlFGUQxIyQGc7YyLEGFpCDNE4PnMyLBGnNwfUMmzw45ZOAHiYeQa0kMp88vmYbkfgLnx4moM1x\r\nhJ7N4YhWX04kSHQ+wwaNUOtKPuOWvs6wO" +
"a5hNqPzgKDkvFmFGnD+IH6NrhhRKyjYECdJvuFUxY2N\r\nJv+kUQS3JndAIkbGyViNZh4F8XIoVJXOVpiB7gp+0YBdlgz8wB+o7QJ3LzwBcoVTwuRQCQVP+aB+\r\nbaLjG4PUacJswH+ohpNBtRR8ksCJY6M4r2Mog8wnRYUH8HMI7HNfKE1Ga8FpLZQIFAliXavuYFng\r\nqQcuBEwqhcIMxhKDat1rQeVgQcP814eq+5kE/bD2PwH5aPtt+Oz7vbT5aUTGEJMEfcczfCfoDUwR\r\nZBOWLSOVwBkYag8ncICR4wM2v4rhtsnywsKzZ9hvn4s3w4jdx/h9Zc9yEVLejA5fxb59y3Y0J9qW\r\nOu1lMDLU5M1z1a7n60tDxKpFsyktQBvalt0CI88hLHPg1Gj/ZczQ2D1iiqBAyxFQ6z+69av7NVXY\r\nbtOL7rYnfbm66MkviVWv7hARA6UepXuq8qtQeh2hBTCu2WnvUWr7ue0o3B6IMZcnoK71dtuD7S48\r\nfg3+lqXWOg+XVgsWQdz/0il6RM02pbx6YaR7trC6s5C2q7t6ey9sd3/SmbqOzmJ7S1zwbC8o7av5\r\ntnJnSdk+grtT6pXaUri9Z1fn21t5sPcyWdMEuRz+y9WAq3spuKliS28WA0v+YktwLWKuuZ2rErUk\r\nersBvSC8TdCZ3XRYXBbFQ1NN1Sty+s5u0SHWTkT/bou6NLmwllB6Ub8AUY1RduHyfAfVl75SGjGw\r\ntXO5LHpVYuEFgtK7WX+pX3S5bAsfd1ttIX+pj1GpwGr1UK9v9UFhi+bFK8pDHWJCa0qzeljyqkzF\r\nErXoynaKxRcmgQFMEyRkBcGe1fcpoV2qOWxZ0Z/V17Imu7vVE20tj9ch5lN+oVd8XYn7gIDK1P60\r\nNBAP23o9VeSFj7XsQFwUsnpK1d+1612WnVfVZWI10Kb0+iVbVq8X2n3x8txEeUz5y7nYSwRla9mY\r\nvthyhK+6NXOIslNLXsF+uFrN+lUgnHdsuw4xfbckqPq" +
"POugRhA+2pULR5XDXhL1D87taUPjmQnmm\r\n20pvKJXgb6+jFGOO86pOqRRNgBLT6llfTHeUymmr1C9h+2ZZ3LDtibUUSNDbCps2dXD5tXpw1jsP\r\n98SwpzNjQmpaJ+7vpTvby2JvYyCGNO7VjUHvXJRcdk2hqtzYUKZ7A+VGR63UzYXVyo6ys4jByKNw\r\n5XZfGWtt9J7NOoa+wGCMTmd/Na17+aaYIug59t++mWYA8Pj2949/PDa7U58DQt23m/zLmCTohRfF\r\nH6S3p9+AxGj7L8VPP412Rvj9H979DjzzRVEaBUijCvDaLuHx7Rwcj4KeA7ywj/bGIR/GHz81fNmH\r\nL/bD4xl4UKqBXEAiMGR5kEBS90zg7cxexVBwMGB60qbNHGqsRQz3cp+MII61hA8klsvng6NhDOHT\r\nEnDqAZQPDmCkWsI9sNEO1WijEkbQNufvZT45+MHIMKpcThAK+FdhIJ4UMy9DBrK89/nk8si8rEnc\r\nG5q0zHCvgEovQh6ZULAAGYGo0oBqSOY3gDZI1dNGgtrHLGeP5jN4fE3l4yu+Jhc0KOj1DFpZn6eb\r\nzaaPkRF8kAC7ch8RlBE+Qt4kaELhI5rlRMTFNGUKYlTCENok16BzTNTJJSJNQkEbFAqZwpCpaLU5\r\nxMBOLRucRsJIZhpEnUGOE3wjgh8kcSZBZBqnfDxqxhAj9zh9CvADZOSDgEuFQbYOhJpcsDkbCRJl\r\nfAaQpkk8kT6bIP4kTqJAOFUGLsO7Mzai6yiKcDinQhAUN+AsXomSHJvhMicsh1ZILoM66/FMvcKj\r\nPDJR5zX+OHqduVtjOUN9JcPlUE41TzbQSuK63jiOvLEwcE1lRrFyhjEfRF2NJraSxBg6YUCjuXg0\r\nV298YA+eCNKeNj7k8ByX47iG6oSsv3/NKiAox/owNO6sI6onvd9Mgn4CZKARDkXxeSAgWj5F705R\r\nA4Yg1gyKzbdUOEc2ouQByTF1hGwY+cwJN8/W6xWK5etWSd30iDW+I" +
"nPGo4aTOsoa+BOOQFErivIV\r\n7TVHIuRYE3gJn1mZEb/LMMaVxH0mvo6VT/FbA3psbsgSGTOKjF8K2sBpVUgdQ1kGqyO5xrtmv40g\r\nl+U41MCxdR6NP2riZrcgPV5x8hVz3ArK4+P0Wo5jcihzkGSs8STKAtnIeJTE48aykzXWWSbDxpsk\r\nepABdW+Y2Yk5mTTBNdhgwsh8JlcIFJDJGTnEamWJhBltmt9QKSbICrkSdZbJ8u9zbFOFGNCDqBOP\r\nZ7iDRJKz8vz4RDFtjkPWVdYVI2E2s/PWb2hA91ond4CjjAqNmyvJhzxnEvQZdsdDwLWSIIvhgdQX\r\ngyCtVk5rc0yClmtvDfHoUH0G4sDfaD71A6AaqymH3w1gaq12nbyDGRgU0vEo0muQRwiozFpn4MML\r\nztSW9HawBwYbkH4UbQiQqySnJAlU7r0bQMb1BpyJBhM/PMhmEvTD2ujr2T8GL3xbfOfnxlG898b+\r\nR2Lmh8PveIbvBL2BKYK2n9mW2nxjEserqPY17klXXeHRWrid1MNQt/ra8q5QSqNUi2f5VTjzQgxv\r\nuS1zMMMX51T8+nHWtn3GeHmEKYICLUeou7Vt2RKVN1u2VMeW2n5dKTEb+/Xz7dpHOKofKLe2weDR\r\nfTi/vae8udhsuVbdqc4g1NnpuVKabVPoxjRFVJWypwqo2LG5NMW4WP3k2V0SxTyW1wvPtQjpS0tt\r\nSalWmiyD9E0HOuZ+N2qp0I36Zsud0rg96ZH2cxrTBGFd/Y1Q0pvF7Svq0kKpFt9jjetlBM439eCK\r\n77bNbqGI/bSvjwnFFqW6OCuWLNnF2lJecIRcehBW0+9OK6sKu8imAEh25FtH4mLR46W2woeCcBF4\r\nXgu3Q7S1YkW7q00dYnrsWxr8oSrfMhWpy5igX969ep/CzE4JPSG7jYiBYkuwBITFX9uAoJW33ZSy\r\nIwpKyk+1ljTb2dilS7df3Du7LFBZr6CnKEco6265dLFVGzc+6xAg5F8KUR1bay9" +
"2hQ4Cn5BBwJPf\r\nPdHbp1VeAKGSjupd1VT2/mHLYTOPQt+FwLJtabHYcrhb+kHR8TK1UwS5s1th+5Ya3P/7Flsrtd96\r\n7C6+Hf1O19H9KPZFd3fLBu6hHcvWjmcftGTvkcaW0uykOvm9gXJg8ww6Ns9UMdspzaZa2bMfgT6w\r\nLyq3dnTKgag+677UB4Xbq6IprB501GELEPwboNYoz0MWkxoKEbZMXaMRpggax6ZJTH/DIusXUR1t\r\n/3sxSdDEHP4PH377YoF/2mqDfyImu7lJgsbWdPy/xewZZlpp0eL4YEmeSMDZG3IwqILQamXDdY3S\r\nIRyuvQa48DIh2cUZBTxHAq4BAngeQxofJYardeAfydgbFAYu64TrLMeS0NMzhmg4D0rag1bcRvsv\r\nYGKF5mOGs9UdOa4S1SYMinktQAJW4BqMnRPaKEKCEyDIGY/mDhJabZQ8Bmw2g89XgY5AJ1HC2ZCt\r\nZ3AwtoVWhIA4oKYgD7AL/iQS8jWSZ1Tg5KNduEfQBsYcb/IHUaTCaNczCMFVjFyZlq+rGB5NovNO\r\n9mleG91sgOyGmYJNItFsMnfQYJ6WPm1EgbzSLvgH/44zS0fQBlxLCxNr1xGQXAqere7gcSTJJxcy\r\nC0wGSaIsGkwY0CbH8AcsGidXcmy0dqJdiBsbRhRFKiRS5JCRabRnkMtyjXW+rE2izkYzE6/kGJZB\r\nkslMhT0gD5JoMoMer2EYgh0YrOzJNEEJ0oyVSSvaXGDYO7hmlaNdDbk84Vw4PkXvjOMrDu8TTvzY\r\nyDIoQ7JJJmlF40XOauZXkjwSdS7cfUJP2STaiGQYJ7fiZCHNo3T3ayg0HcaASpLxU54zvMdEV9SF\r\nZtAmiiZZkiExhCPjiLHxwYU1eTTTyODcQTTHoVg8d8LFMdx5wrLxzGsE0RHVsQErJwxIjk1iOEjM\r\ncnXUinO8lY/XOZYlV37CoIE0lq9kphevflbluAyu4PH6AVmWJzkih0YyiNmM14O5yjoZdOJPB" +
"H3G\r\nTxroravsRIz4Sg5FoHKKs2KogYsacRRrOE84JAPEZU9B+Tz7ODtSvs7dRp1AErKROQH0WE+Gas7Z\r\nBGW4BpsBteYRlCUPEPNKgsBB20EbKhWP4apyNGfFzQ0OR+fhCtADJ5vDp5fJjpAochUzPw8IMuAg\r\nfqaBK3ASJXGURAHJjWQ8txLleRVgIoni1qkmtKZKZliSaxjxOHnsM6MGsmHIrCSa5pN59s6FM6dP\r\ny5S1p+gpCkRkjShr5jGyQpIsyzIuNsOB+wuPq3gcrSAczqtQlI+DCo3SgZR6Lg5X+zpBzUBstI5I\r\n2siZBK01K3c+hlYEmz5DUOaDM0XvmXntPSNTKBSGpgJOfgUgCIUP/COIe8LwmpJcTiTLBlANmaJJ\r\nyAwgJwVICzJRzCsMxz4GzkKlCeYehNGGZmRqda82WWk21+bB84CwamUgMnNHzNOw071X0M0kQTwR\r\nCnJNgPP3zHGTSAwFI2Bpp1wjAWVVRGCYwuBLYvF1BlboETRTBvKAyKCujCJiGJ6bSRAtlwwlSHPS\r\n4LRhmAI+R2CQFAI6e7gHHj5SADg5WbMx0HBiHNiOMpOyG+6DIylDqCSE4S9kImkPAbvwz3B3+MAE\r\nmTxmPIKUMYwPAoeCQUHp0/gxLA8cDcPopBWUB6vwBCiIFGX0kwJnEvRvMifyz8DctG0UzXuNpUyu\r\nvJsk6DueYYqg6mgChOQR4bdBM2bYbWNiIKjsvL1SCAxeN+BcDjiI3dyC0zpGfg8kFddEfpLMD14R\r\nHrbPMbPM15e2ThEUa6Usc0ox3SptbUCDgmdzYgdI0+nAhVtvV2sci65lpajRaKqds643BTOCHiCA\r\nKIulVF+zoQFV0Whey9L9MXDk3mW3W4OUuNlKbbf2vCUwkl9Ubfqzg+L5TulJifjgFaEjnnVEW1HQ\r\ndCBlX+dAiUpQZnWrar9Ii/k9OGPnhdkzhXPbzY399UH5FEEB7Ejtz2pCV67+ritrstdKfpWtdRNw\r\n6XZJv" +
"/nVq/MSYmZlTd/d79ZKN1/s5lqpULJTbYfNExLEqt2v0nft6u5Lpr0kxD54s+LOfLo1F7tI\r\ntzxu13IB2Qp1tkvi5mXncFWMPU1vCblWNw8d+i7WHnlFwBw1yjL0iuAuZgMPXhH8Dpt9d9qEHlTr\r\n5S2fZii9pgjydwVxp7QVouy7Lstiq8BZaqsFDN9bbJUs+ZfNxL0Gf3anhgk9qm3LZm1YyxLwUBtU\r\n2/UhTGnSlyBc9PcE72tT+fQaW1YMXIiHmsK5GNo933ZVF7P51TSV1i+LgeX8OLEjrwj6m9jQK4KQ\r\nF0KH2R3MYhGKKgs58orQC8RUE14RRvAvL6aukGdLoh8xRVChtSTuUFubLcEUWAqpOoGlnUGslGpj\r\nS5TH9m0E3VxsH2a9riPdtq7QvfEv6c53Lj/aSnDp+ZLFshVz7LjM+dcIKizvL52B2tg7+rmzmCMc\r\nAKWDuyp95MYconewCw9GgF4RLrOWG2FV8oqQb0teEVJpauQVYT+1aK9Brwi2Sa8II+zv6kM672vL\r\nr58R9DLOCtRv77QljBlOhI391Xs29KAZhCpCEAva7RxB2nlREfcQZfPXeUV4GZMEacDbwxx4YYD/\r\n4Wb056savkXAc9+GxzQPuX1VSpuHsGHoS9A82M6FOyDS8CcFwO1EOnAghT3GmLsYxXkKGu2NDicw\r\nkRfE5FWbJOgVg0cPL5m/GW9+lP+HYPJ1+VshmzUFb+1+pGB6LEKyoAYBl0Q+r5520ijcBB6SPiTT\r\nQhM29PtmX0gDALAFowctNBQ3skENpHuugJIUZg/Zjl3KN2iarM3TpZs9WAUjFmieB6qe5FDhtgZG\r\nMFA0bSIyH43MJ7SgjlBJKKm9QMRkMghOw6jPaq6Vkmq1iWYZKsvu742EwnpMHIxOz4Tc14wEm2CH\r\nkJ1WaOOBXK4wExGz4tTqe2aGjDaActaMMmir6J5uBqHuEaojQRVGMV4EHWmCOENb3+B3bYBG6GAd\r\nZhL0kx61RowyQ4W" +
"PRyLBJJHIoXGftRyxMpXIfNOFGOYVxmM5Yz02MJEDIilLuLiKwUDIiGRzuuZS\r\n0mSQYZikE/NZCVpm5IK5hsL1xnJMCYlcBWs4DxKGhTLBJ/GKNurEjzOsAl8x4FP2r2gCP1AYFVww\r\nqThl6ATfiCatvlOiaQ0WV2a11kQN1SaJZEUGRLdGMOs84DkJ855J0GfuNmqooyiBNRrJDF5e424/\r\nkEiG53EU4VkUydUznGwdJxu5E5RLnsSjGTRTx9Ec4uL4xqTgn7m7D+QJ/4Wsq1AOQfhgwsnJWWR9\r\nfH7hq/gMbZhFGomEq0xghkyDODjlV5wcQ7KGqZl+cI5iPIKhLH/C45VEk+OSLM/WcQ5lsVkEya9B\r\nzDrZ4NgTjkdZHGE5NE6eHMtnE/SDa4XI4CfsbSmOskitEc3ECddBBj1o5FRYI8fzJ1asss4ZOb7O\r\nMZl6I+riMa6SO8lhdXRqWmYiE2/yqBE1IM4Myx6gZV+SY8xoOfMeG3qPBLUYA39wjTGM4pS7Ixuf\r\n+UpzyjGE3GfAoJG3eoMhuSjJYRwC/iQzDJqZdSkSORxD4+Z4BuNgXFQyC8fDuaUzCfp9hI0nVYwz\r\nblhxqhiE0V6zSJOtGAjGwDAgBBp6VKzjjTLYCRpVTCJ5QCCVa2uEjDNTOi8aJlUxTIQh5s2M6uD2\r\nmjwwsISx8Z5pqOAWa86bD7R0MphDFOSKNkGw5WRDkYtHVFOG7OTXqriBtDIGFZGraI1318ncSSV3\r\nwDSTpyuTMSdAJ4/XzfPX0G8KwzSZZJxhiGQO2o6bSZD8LgE71OHnAfqWhibQJAtqUB0FQxKgZ1bE\r\nb+VgBxoKgBPibmnwCAHJxsyuSRglhZosmKfs/nboS+E9397uFU2aJsAOdKtwf6uFucHy4MG0nTZw\r\nWvoyAbtmOJF7nWz4JJHp103IAYDHnVbbZBHYQ8PKwb+3CVCJmd/Ffvrhp3fgD6Ptfyq+Rb4Po+0T\r\nfvhu5O2b8IygyRftaWg64P97D" +
"afByOMYpZsoYTKv8VMP+2A7W6YHaIbR3uXCcwovT+yQMEVQ+HJo\r\nhkmaGycVODZMBIC2jbYdYiElBqS1bV97YBQ7kgxgPKrt0jO2Egqc0cSgUiEdoM7HIhbOwe42BZ2G\r\nFrLK2INiZr93edQ7F92u5UUhXXOA0avfs031F7MD/7TJ9rPWXKgEMxz63uyFR/N8qrt/2HQNB1ZT\r\nKR7gVoleyZZV1fT6NJQpgqhlzfauxU/dnORdltqRGKI8i5e9wGUt5W6lDlP6VGq71HWIAayzMF+g\r\n+rHup6UYZdrV79luDi8vV72qp1F/4Khq2XHpDvWl3qWO+ihu1zDTbkqMfeyHW0v+VMHl2aFMAWwQ\r\nOBL93cNSt5X1e9z6UeKCqbUKKryoujg8Shf3NBvVvLkTswv++TPXlO7mbOGj9yR0qasJelCe5ZPF\r\nQgn9gOtcXFiyLShrKX1p1Sts11Sg8MCk1TXbQucK8ZYsFgv0LxnQv6ixmCSoejkn7lJtYUdvzjuo\r\ni0PN4nxaCLnMhZS+KLQF79LZpQVzOcRF6rKmd4SvAFV5TK+276QW9Rb/TXbx09MMp7NYtoYJdn3+\r\naKeo8i+JgYG/SHXFwLmf0m8fFoVerXuFLcdSNQ40j9L2rnkH28s/aPxic32X2i5uegVlYGnf1XN0\r\nFrPp2tJOcenRfOED0lSNonS7nLC9sFoULNmbw6NF18fCXhWEX+oOOb1NVbhygcJL3cPJ/tdWA7XA\r\n9KYFz2FJjC3HXtS7TrWgHVfXS5mO3BZ9dy9POcT9Uk9P3aR2epauYDoKl3RtoSWkRG+PulnyCzpq\r\nqdCllmIl96XL0rOY2rXWE0H5WtdeyG6n3HuFVraQFXcuLy2UWty+vOwu2VpUd19PtexUqburEkN6\r\nj1tY9pr39Q9a3cKqPes+ErcDSzvU6qJwIW7rj3YCnrx552r6Fkt3C0eL9pYqFQ60C3ql39725C16\r\nbLXaXXR0F1vUUV8A0ulbFqo/bhISwK2r6bo" +
"xR0/o2hezOkr/Yk803Umn4bpSsIXeaqBGffNi+B1h\r\n+L1gszPmxqYqqcm/VjsbyrmNYfMcbSRIRs6GSnmorgdZa4Z5wPwkn8KgO+18hbtVpbi5AeMMowOE\r\n95SiewvmkR5+z4BROlIWj3EmIFWuCjKQ5Duzu0ZSS+GbF+kYJaZffrgov8IOCBQERXqOSYJGKqNv\r\nxUt6qN8GqMV6Odd3ldXpnY/2RlD2Poz23oERGUNMEvSKwuy/DlDzMQGopXknZg411h4nfT0DfCV/\r\neW3qK4Av8KNdSXc1TAodJcwYIj0ADBzuwUgF6pykA6isgaMJKXAU5wFAstHeN2CozXusz6Oo2jcI\r\nkpvjyePhJDeQRCsZC4LDrnvtKZIkooYykFQaUL0pFE0cR4KghjADLaiEVgYrQiettPGZWfBnoCNx\r\nH80owJA1rpDThDWSi/uMDIEE1xhfbmq0SjcR6HYSSvweuYagk3GQRM4AwWBto0QlCgeM9Gfj3UyC\r\nfiIbTIYtQwvpOcDFqeT/z8ooDHen/EGOYwzzTlDBeehuYPaiUzAgZ8vO+GkFZGDIEVg8yVytWAl6\r\nnUFZNvNW2vu1DBo3LDB4mSAb0c8oGjfiVlSRaWhPYeBEavqai3MHkfkmkytHgFzvsidPG3BmvkkY\r\nGL5hjDetimSmcco0c/MRkrudSdBnLvohk+FRM4rF0WQSX2HnM1gdQ9hbivmQ5FBwLpOpc1g8c4K+\r\nodaJZvD6Su4EZVQcAnLDGQypK2h6nTWi9anpUs8gv0avOZQzZBrR3EHS3DA0DCskhzh5qxQ4kVpr\r\nbMw5cRYnMRbl6uybeUuQr6vgzKoMyq+Yef6ExZEGWYcVz71B0A8ZZJ5lOM4IPS80m2YOVXE4QtTj\r\nUSfK5ICQmXgO5ypGHGffuk8SmUqO5eu8ikfjmcwKiWYQRKZYx8C9Mrm49SV8RhGeX6gYOBYNEgZU\r\ndUCWcyQXJDkYiE0kpyNcBTWe8CjJYDh0uDAKnwm54hQjc" +
"bxRUsUxBkeMjVOcr6NMizNjswnSXpMr\r\n80GGIJt8o5ygzRWCZAyIAivTtBmZLxsYhjAQOcZ40ETeulK04bhJOOMEUuHZMmE1g/uyTJTXyYYh\r\n9/ZdQBsQWdTQJAkjewDudETOyNaR+VNElgCBU8m1BpZZSxrmDREgatPwngYEmii5EmFOCYbIkVaY\r\nKsKYraDiBrJCzyRILoOaL/h5xnonl8nghxqajibjWrAP+mrQ4crlcrjIE8QYKZ5eBZBUDj8aJKzH\r\ncIkrTCQH+UvOC94EdHsw9IUArcMlwD70cjAMnE4O40B9F3gUgQSjwLcAHxzgASK/lZ6UoM63w4rT\r\nb3hFGCmNfvrpw5jW6Q/PtUrfgvGs/hvwXWH2TXiLoDFdz3Dv5RHLfyS+RdRX404RlPY/elEcGkuT\r\n3BhU9XObWWgQHMAk/X0PHhd32Yeb9GjdJXSbKu4/WNj3ZrcKz63th1d3Pp7ZByCFV+j4j0I1jzRt\r\nZt98EUrZDidWzZ0t6sHoqT0aQe2M2ajaBkPn584QxhEeOlQAML22fHWKoMBHZZhaslH6rDJwlM/u\r\n2G/UMfPc2cLHnQXTjR86cujlszrqPcvI0rtLupAOqgv5fcqTPxLDgqgb9AqerklYzheP8g5bFtSg\r\nE/i4X3p2/QrL/my6uLq4Ku4uga0NDs43YqnDnuhHN6AjySeEi8ubfg9lEjwFj1gNmJV6U3tvhxrk\r\nHTcDvefT0qL5dY5sRaonuPVqf7ZXe1LUTGCSoOol4GjgL3WpxcOW/vCG0vhdHwsfq4dCgLK7urHd\r\nlkDVUlSoNIo/C16s1YWeGGpqilJSAfNc2CwK2/paj7opthy29uKVHk6f2nZo8qVnVdBr3FmxsOpe\r\nEvdrHptr4BVsqTN9mG8fFtGv/jGlCoCb6h3yMcylry2J2xjWc/UuLUKoKGhqS7slvRcrvdI2AGyl\r\nLHW0c7Xk1VFQEfwSplqQl0ot6tv23lG+XTLZB4FUzC4I55t2v7ndFTy" +
"L+pJJ3x749bMdRkioBkz+\r\nG+x8TywIpYK+vYN9CGFLAZd5kYpdFlX6mnCI6VqprbMrs6lLTdYYIPbB7QAE5fdEd8CTp9SLWY1m\r\n+6iqFxwFLjS5LjVtpwKtTFsQ1AVWLCwtOvzZAqXXdwNLMaGoKrRdS6/3RTaXvq0OFCnMBGo5CpvC\r\ndCfdXxb7F2dfNzZEtXJD3ARdkFopajoaTWej87Uj7m9tbGigg+O3AXVrnapSrPa3xL4mDMrvr3bU\r\nG/sbGx31nFKtGQxCg51zcd+0NeGuZYjtj9UNcWPDMieGB6AfPJOmqF6IaTjf7EllN0T/XFRvdTT9\r\njlpS7oXUG/25zT6I29lQdzafDE++gDPTVlWTViv76o6kwnsB0wR9xxQmCfpXGxN5vbx/n3GT38/2\r\nijAarPx2jBwUSPbTwP4w4wdPBI8B/4GYvWZ1FOkfAVmEBnTQCgUYwimgEThwpJU176XVObKItBnx\r\n9R+FmYPVfyBBCRJHEgqazq3QcpmlkVBAH4AGHi0rfHIFfcqCcwqFNvKw/vY/B28QNDGxTxoiP15k\r\nsDe85NLA+S21QjRTR3J1BEf5FRJnGyyOMmQiM58Mkhz4h6FIHeF4hHtNuQjbFyhDDmesgu1oOZe0\r\ndw+Cx1ONZnuO9l9tkzMKkkp5wGyCtE1iKAzUANAEAa4xuDugZvmebvru4T+aboJQogmFhQqDUb7T\r\nSGQQtN4gG84Fwwmi4gBb+ErUNd9C2RMuiRIggERyDf6VWWByHy2LQOOJPiA/tKMY9BnAvdoM0oSP\r\nJuAEzFFEUHGFAYg8svEoMxxDlQyUa1gHuJ8A/7XrhLQ/SvQE373MJ7sfm/01k6CEk2vcGXwyQqYg\r\naIPWZVX4MpWmnJz3NRMRvnzdiKp8BF2rrGdWiEg50WzKiddcpSb0eDzHMtbTBrSXZ1Y11k+CWgPP\r\nmVEUCSJcI9c4tTrjrxCUcFZ4xIBxyTqB3F7jK0m8THLBxHoOTlM0Y3Ej92gNkI5wi" +
"IJY546bgDbJ\r\n8UhTriDkEUVEATiB5h2v2SAhzx0wPpmsOWGHDkJSnSPj+tHZLYi7g747MhzLxXNog2WRDH7gQusI\r\nj4P2ELzGEdyMSqENFcfFUYx99R4BzyltAjbfRELrg18QnI0EuKCyoaJKRtM+eIWhWu0FrLHHuUbU\r\nfCA5or3GDpIYQaJBQzAKLhKaO0E+sI/E0hGMucYarOoE2njM8Sxy0uBQ5AuCcXzDWUd5jlyY54Gk\r\nroaTxbnp8hKuci63EB9T1M4k6Ae+vM6XMxzDm1EuyKMotkKyPM6a61aeAcLhVo4vsxx2QKI8Yq4f\r\nkHF+zObjJGjFPfQxLfclg/CjDB2BDV1Ogx+4isPf6M9zSJM4E+jxZ+xOVaavsfIpdwva4Tx7EEGD\r\nmTg6sVo/Ai4TjkLHI2w0V2eBtKgBazjxuBPFUTN0PGKEjkfQDJcZczwyQiJTIeOf0DHLqbNvMQOH\r\nwAm3RC7XMPIH1lwyA4poOOMkYkDR4+t41MrwcSMItUJHuGQ9nnnN8qX29CToxObXYKuHK53h0mOf\r\nwddkZJFn7fwZEuS8wXod164jEfbumgWFV4xoOXqNQ2ckRmhJ8VExTV9nGk6+Ybai8ySSSJadCDuP\r\noxXrdWbFyBpRxmqwIgjaMKqsSSSCPrujacBl02oeu8yzbzHpWoM+WQvn0kuQ5tTD6w6/a8KOcBgK\r\n/1+T6EvLE4aQf+bLP2Xm6QS0PwCnDSPgLj1BcS6uenueKw3tKMLnTqIJGyFseLALlp4c95KAo4gA\r\n4BwMgVppGAnsXJO38ADcyfA/kHworxRllOgJUvD4gorZBI0ivQ/wrW+0+wLA7ZpZoe8TuUaGZ+pI\r\nss5xPOpE6as37LhKeOQdcPIvxj+QoPvx14dnoK1N6Mdda8DiyaCzoUCS8WaGsUaxWfO7/zGYJdab\r\nmEnQez+avAu0/FYLHVjDL0laaE1UK7+lE6eNZzOq/7Mwcyz2wz8fv/9ptPOfipmj+e94hu8EvYE" +
"p\r\ngtz6h/W/ttEHxvBHMQzDNsSqF3p3qd70e1CJ+fTB7GVUTWJPYxJF3TNd75n3Y7X3uiJdQqjb2VkS\r\n0yDihSjuWy7yexvdwWZPs7O08cwwabgtfWTRjTT/PbDdgcJBZ9jp/oM1gSk9LYAt+4oaegJTBAVS\r\nAZ3FZDkPW/yq1c3uIG9xtyw21XLI9mVr06UrKS39S1Mh1XfrCqWQZZDv7+yFLUrLC06GNLX+gknY\r\n2YulLB2bZ7+92ler3bq0fUnc2HYNXnLSM4aqv2BWH57H0NCnc/FMiB31hZhdv/3lw/7hqls1ijRC\r\n+lJX83T7i60ty2DHI6ax1U17y2S/SSlNO92BSdfDliym/OqVx+bojJO7k+1tbacG3V73JrWR39u2\r\nm9TSF7spTBEUm9s+RE27LmHgN1OHGHXZFrJegTra6ZY06axYaGGUIPhP1F5ccBxigsvU6hWLeiHw\r\nwocyL0W5lmJYm1LZrlyutr5FBbBWSdeak6bqzyZoU9hElA5bSyX6l3e8jpBjR+WmOJG6CLXnFpFR\r\npBGgqVKXKqYL1DChuCouFrOLOiqgd+ntFNUWAi7PoY7r19DLm2yeao1NkfX/YdFebF0Kfr0r4PFz\r\nl/bLbPttggIOwZLyFvmAKbYqHGZ7DtslVdALwuXNZSfdsmT9gokS9FeWQ6zdPjSr/Sqvy9W1HS2+\r\nsDA/vLC/cNMqCkuHQMjYVkCF3bR0MUtLs495xJec9IyhGmjbW0v5w7omsKwMBfSpnZLSmxVrg2JK\r\nPf0VLX1oEbrzi10XJfQF8WzX4qIsrnbPkW9TR7bLrFel7x7tFFF9V+hOfK7aEfyq3VT34yKIqt/F\r\n9PvIIjo6NY4pgvbty1Vl+mY5pFNvDNI3SiW04rmh3NZdmLbEHctc9WYAoOybeh1T6EapG/TOQ0tK\r\nZeiFLgV0Qv2vPdOgr/vq3hvMhZR90f0x5G+JaUtKE3px0vYTQksbeQu0TqIGfVBYd3azDK31qjfy\r\nKfUzk8m" +
"h7vLm1tnN3uaNcgAdbIcGN3uDrYFyoFam1ereIGRSbupWw+pt3cbEFyC35WK/p+yEQFSl\r\nbm+woS68ZMJjiqB/NsKFB5MK/3l42V3bJEH/9Jk8f5j7bXON/qkYTWSaNT/oxWlj4yOD3zZKeEr9\r\nHzzamP3ZR1JqTOHpCxZNK97/OUtST0xkBniRoKXlU96wh4N3SWshHd9D86RaOG0cnJJBzYtWDmeS\r\nSyv/p5GYtlX6bjzqDMYxc7AaJXH2DmpNJG0Q1KfQiSYChAV5aelEZJ45hjujrGaCJliGxCtroNoS\r\n5PKo8yAh1drJxRkpdKiuARkbypCQJMcqmGHqhGpejx5/JuNOjI0aUSaHKq4ziIF/YSm8Noc1JGql\r\nYr5FUwD9dSfkUAzJbceoWjMJ+ilTJlnGWV7P8Hz8lIvnuBUnhjo5IpHjrHyDOrEm+bhqyoTAy0i4\r\nWMVnvkyvsejK6QGJHq+r6nGSNbPHTf742oxwK2YOsRoOnKyTQ2AZ5XXuOIcuSLNntcQJ0tAfnOJM\r\nIhePslAnXo5AX8/ss8ZCG1AtiyaRpIpbMXIH36JMSfAHp1iFP2B5RvX0HeANgo6dWJxkrlFobyGI\r\nggJRA19HD9ZPUOj8Ok7WMRJ711ztNUzFGhpReg1LskZod8CIODGcRdDjUza6zvOSMVE22cidcFYX\r\nu1JHK9dcNMmit+BSytfxEy7uPHCifDlznMiQKMtWTlkWJdFndj+1SfZDDgU58wegFBb9hiaUwNBc\r\n4xTHWSfeiJ7wI5sZs2+xDHQGhJevEasVyfEN0sCyPJtpgLbQMK7kcihJcozqzXngEFozHzdXCCah\r\nUvA4wse1TR5D+BXQKNYyvJVtgJyh+YgGj7OMCmmAMhIkzxO8lUlWaFmSQzJoxZhBDQ3AAN/IoCtm\r\nFCV59tm1ge6z0Ai0lsFkMo3ke+w6PGBNdZc8IHE+Dq6LNcOOvs/MJGhNYZBpI8H7e2jkU1rZD7+R\r\nyYh7Odj4fPcRBXQpJ" +
"uXzJuQE7aOT87RProCfrOTwa1+kCf7I5QaFzwd6bCNLN+8jQR8oJALKAHeL\r\nQqtoKhSgBwddkiLo80UU9757xT0BgmXgQPuS3zaQnYwG2cFsgJCj0HfBBx+mTSDLvaJ8T4weIbMJ\r\ngs8d2FtJX2NBVcAO+AsDwEb6MgkD3wfwFIN5gTwkXTv8P5YXyHm9CR8EUsZSODgtFQwLGO7BACiC\r\nlEQqXMp5ElIsmApGea9wEqR0w/KBIKPAmQSNltz9q/CPX6n4j8Dk+/QkQd/xDFMEbaqfKZbU0wPR\r\nwevTasexORDTamh5s/M4RNwEx+/EVxHOHRxaZgBj0PBWFQ5bz7Zg6QNxMC6mlOtglHP13SWM8FUD\r\n8JKJzhGmCPKrlkMX4sB2BAbSyi1lRzyLUR9BVZXgEPzmRLXtyKQZbIiDZxNTp7FPeQLmOdHePepv\r\nDDSwfuFLPRh3i2Dor9wAhy8vXx7C9rF2tH1YcmMDi7hZXNpurS6qtsSqv7QXy1qElPfqae55+tB+\r\nMdBcXijFNMjR74B8pjc0g7nFadXji4id76S67dejThEUMHf8pVg2hhawNqd3lebcZnEzIFhclzcu\r\n6qaosjv8qN0i6NuuF9wQTSId8AQcF2IRFduBUrtwmRX9yz3TIQdSF1p6SiiMVfIZYhf5rLjj2djV\r\nxD6kd5fcrtVFQQkuji11BgovibEndUn68GN6N6svXOlbHlCoPky1LLulQMn8infrKQTO86mFGZJM\r\nEVRzuKmrHtXtFh2LDpsn8IdtoWPL7ruO8ipw2Uo3Lo3NGHMtF1x7l281IWXMsRmYF3c5NSWoi6p9\r\nQYx5YsWWhdrzunrCoIbNsDA7NFVKzQ1NlSp3z/ehqVJb3px3gEYYQ/bHNF+a0KH+kPNfZXWFrJjH\r\nMGEpv9u6CfQF/7scRfn3Fm+uxixqTGOKoMXSjV5v02/bb7J9z/5qfguEmBaFvmc7tefuCXs2/X7b\r\nYqJSPfWD3/5XsSOserNbog7kdTO" +
"4ye+qoF0TU+EoHDgyLdsOSzv6GYr7xeX93tmNKHbTWc1ZDKT5\r\naBNAfQtZW8vR159vj90SmwGzjnLc6AT14pHo/RBO2bGlmE43uNl5VwsKH2aVvfxvNFX6D4ANuhp7\r\nghsuUpiB9EPH/rjzblQXqTfUld+ESYJGbwL/BCi3Jl56Ouez34Ge7Id+87vSxeBitPdrMSJjiEmC\r\n/nmWF6Zecb/tjffb8Bvznj3UkOwJQMA3d2mGjgQ4f2Z8Ds17AEcR0vYhkwe8Z/H/LRiMJYaL/kHJ\r\n0FUDXD37XJkHIRlRGA3iJcXOcPcdeBhegGyfBjEzCUqcIuUodIKTAKOTSFNGaCWrENFkMJGwvjZd\r\n82WAUS3DyBJ09LQM8oA5QsOgMON185v6EtqIzEesBmSFQMrQ4QO9zkRyQQPy0oRI+jQuS6xBs6ig\r\nFGJeS8xDXuGyY8kWwyusQsgjDNSxQaMQUaIcHeU9k6CfeKRprZiZ5gHJRY3xdZawKpxWuRMvG5tj\r\nXnHegwSJxhmDlbCS6LwvV2maFcb5JBMxHyfIxptUyw0YkjmI5DgSPU5oCa7sPAnm2Ezjhcl7NIFX\r\nFGYgnTWYZKK5hegVajiImEHYMbjahoOm+dUJbYkcLiMihJGpM1Zr2Tia1TeToCiPJnHo46WhR6PJ\r\nEwxNnrA8iiLQ6/WTt5h3IcovREscijIkyrMIxtRRPIkfcCfIT3V0ppFVCWuq0zobdB6c8lYjQ2BJ\r\njrt1xifcqD9Avk4iTYxjOWiqNOo8sdYR8wmL8skvHKtCMZznXnVt/5nHrdAiK4ObcTaeqQ/d/rxB\r\nUMOJOA9cVpxsRI0NA4rWuZUcHuc5jvnWFqQCjQBl+HmykuGsHFqXnPrgDSKBks8Vp1PQnjau0cxB\r\n5liRQ5sE48pwCyRXVpAvzN6TK045aKoUZ6GpUjNyAi7ICVqpcXidzaG4lXzVuK72FM9waAahUDQX\r\nN3PYyVBbObsPSrIVotmcN8Yj5rsIsT6fRCRbC" +
"/EIwjDvUiQ+gjYojAyjMCBM02AAVwkBd66ZAd2I\r\nlnixK5kATZQTybiM0Z6C+LQ5rl0jkqw1CS2JTkPuI0FPVZknEMLMaIkm05x3xkGZDDJvxOOn8TE3\r\nQFOgDcEfGNDZ5crJgzLB5KzDzGcSBC0dQO0Rrb3XwiVLsJMDx7egywMPB+mz0bsBn2L0vfyWlt8a\r\noIEJ+pbWgmfRvewdVhuksrX39DAueIpJkkDLCy9gKB2IeQviQ83X0EhEgs6xQdBZv14YOAWzvZWU\r\ndjQ0iArxTssL/1D84cO/5Xvqh19n8+G75YVvwmsEaaTfBL5VFfVvwvTUt7emwg3xaqQpgvKl0eAw\r\nnE9Ja5s3H20Pnrkltya2JdE9e3LPCDuuhyHyPgXX9o+mb7n1Su+Mpf4jvGR5AaTMO5SBpSnLC1U9\r\nnNoFEJbGv+rHVc7pocWH8LlYHU0peTaz5FdYXlhS6j2Lgj613Tb33PqO6G6de835y5RJ3dO1hFWb\r\n2XvkxZYWZ6kqRoh1hd6gty1sVS+XFx1+XSDb1wNZD7vZTu1NTc1LlhcOLXqqpWsNpiwvbC7s5ReU\r\nelNMaN9sC7ZPN7pYVhkTtqDo+dRO16Rr7yyoYx+9Qm9hWnH4zZYXxFqpd1gUCuZYm9IL+U8e8RDL\r\nBlJ696XDpqdUasp7pa8d7bhS79C1+BeWYn3h5tP8GSWGL6muxytcAiFsu9nttz2Qv2B5Ycm2W8oK\r\nH3dKF5OWF9KHQuDSVGyxpoW9osuuzx+aC5ee2J64i5ljjoJ5Ubh0C+FdlLoRAtMt99stL7QvvEWX\r\nw7a0aBfa+hr2MU2ZKL0yUNP7Xe2sS98+LOrb+sO2XnjbeofdpC9cUhS2JBYESne0TelNh45lcV+v\r\nwxxvtr+XLC/s628EypMXpi0vOPzmdqzoOgq3HIFsiGoLOm+7XVwOAdFvWr2W/qjmEPTFkmO7HXjW\r\ngr7Z8sKGpqre2oDobGwo1ZqzC2haNO11pNXguC+GBhuakPq" +
"hP5mJDbGz0e+kofkV07nYEdXnm2r3\r\nKjQq0ze9qfF/yfKCVG7VdDFleUGzAc1CqDsbVY1yo69RKoHwm4utcyi6eis0qCrVolIJalXdSE9f\r\nmH+Y5YWzb9br/XtxdvOuLxrvwSRBr1k6+OGn0c6/DL/N8sIPf/gNAs9aq/H5Dlpig+vSwBAYjBbA\r\nOz543x+aT4AAo5XHKWZQMwXOSidpcH7aagNMDQCCR2cec4GAZttADvA3ChkHGGqALOVgwCGNOOh7\r\nLSwAhIAA8F+y6fCA6ZLBARQM7sGos0w8yKR8hxGHIQAzhxraprWpiFhlhgod8cnlhgNZ4no+IU80\r\npRlg9/cROA8OQA7nxhkqd4l15j7RbCaIINhL3IOx1pM+QgtSKxSyJr3epOE8LjoBRqBSWjBW0q4x\r\nPjAkJRLE/EtDYLlMYShrIwoFTRMHvlNGZiRomoGmCORyRRDKNooIAYqAKyTBGAwOI4GAa8wdlISG\r\nURVNLTgHI8AzMNooFYRcZiyD0RoN6/co+Gx1h6thVPFxI2ZNYPHEOhZvMgTHyAzJIME0GXo9E0wq\r\nMiuReRmj0Bowq4KJcMcMGBMagoYkx9wzZUXyQfaEk0docp5YuMudaI2KJmNo5hoMQ8z7GMbYZBR8\r\nkIbeY9AXDVYmnCqWNZwwZDDBNyJ4xYgTUTPaSHxaSUSxxg8LP44pz7VJ/O466UsGDdCfcIQJ6pH5\r\nZjJ4bWwmzAvRInrN+BjCl5RFDhQRUPi4si5BoSCqjCAIg+FRjjcVZg0yHuEZA4ferl/Fkyckx7I4\r\ny6LzzgVmDbpExhpYncWPtRG+ErlCWTae41CSRU9xaGIBRUFzlbTma/xd9Jq99Sys8BypYrFGrs7G\r\nM6z5hMSZeqXIZQBBGJfBn61DhvisMqJ4mWScB1EWJeBswINoDsVz+EHUiMdz+PwYQQkWq2RWyIYR\r\nZTMrOSAgz6p4Hq5tjxoXKl8ayROW45krls2gfB3Fj8cuiNaJRnC24TwhW" +
"Y5jRnnOJOgnfuW0ocBW\r\nCIznTpjPGJGpc6iRQ5x4Y50/WfkhwzIoi9St5Ipc5jNgKIajXDB3QPJY/Jo1cujJAV7+DL0nA7lB\r\nS8utRA0ZHM3wBAqqWecQOJ+PP3AiTqzOl+lTFnokf0kj+pk9NmJ3Gca5kpBl4uvSsvD1HMctoFHX\r\nwgm2EH9SgtFNuBj2zsU4G06ukUErbCaOovMYd4pGnewJ4KWOHZAcuKhJDl8hx1fI38sV4OKecmid\r\nR+O5B8XaTIJ+MB5HktAzd9x6a6h8tibM7AE4ZAwMGc+x5c/JZNmYjJvjhvnkcSQTT7Lx5ClrJJLW\r\neZW1YrCSiLFxfJ1MJkGl6UgGYY/pCJM0JA0ok1SQjYMcakVUBwTJWqELoeBnsqEgX3TAkwCkVxLJ\r\nJlleyzUUqhUiw9w2WSJxOk9rDUzCOKYEow1M1OpsGFgDAmI2kkSSQawHTaMR46KGeashmWtYgYCs\r\n1Yg3jAgzYecUtCAGZwlEZTUyp8TozBsKM1Ai6NVutVD3JAMPmQS04QmVULQ2AfVLsLcFEeBdBE7A\r\nc6AHBGFwITZ9ewufe/CkTCa7T9AK+IgB4dC66T3smsH5BOylYUJCUnU9qKkmca8o34LCZYT0LBx6\r\n9AGPAPi0lEGzDeNKsDv4KIS9L5T7FgoDhLpPGPkKDR7IQ/UZKDlhRucTQNZRqiHoxDoiyQSiPpyZ\r\nrTD738EfRttHPAt4BX+YfM2fJOg7nuFFgjQzx0pvDsVfwItpXgo8+zW5S9h4nvJX5zWGKYIWXWBQ\r\nu+2YOZJZfFsXBBHSX3j1W6Gh6VP7uKI3NFIFtGEFvFcTmhNoThDARg28wkW14NmMfRRDwpxX1REX\r\nl87GXDw/YVTEfkfyPARhEquLQkcUH/QiO09TSUYGV4dYhA6238AUQYGlkD+bF3o2Sicsi7ZLh/tS\r\npwvr/FmBovbcQq+WVQewPmV59FL0OkLYea24XODghJRuzeUBqfu2fNYtDPxCHxrNrHH" +
"9wyVxk1IH\r\n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\r\nddCxBgwcB" +
"/RkLQmVHmoyHmeYmTTw9zq2Le/R/E0RFHCEdGrd1vbNfrbfAVuduhNS6jo9U2/LrQ7d\r\nnKcL1Cjmm4i1zJsgpd+xun0zt29S3ly4KeHS01s+PLKlRNGPKv2va91igp0qtdvCnLioz/pdnh2s\r\nXygNAh8LpW2BmpyGurnwe/cCkNVdcPTTujBmUvd6ok13UV3YC4Nw5TYoeK9646mC3XGFpFu4OQ97\r\nlDqTrtcDlyJ8oz6Hi16nMU2QaqdlKgo1ffvqyH9FXeovu4VDTOBjrkGMo/SUvvtugvyYo4YJLbuQ\r\nvdQLxdahas7tavt1gdbhx3xJdO9mNw9fUqBK2BQ2Kap0Eyh6dEKVElqr4SPRuxpy7aWz3uXCZBPa\r\nLDpiLXWRalk+6WpXepelRgXa9sPVajFbwNS7pZLeuIhluyX/lVAcL9D/B6+liF1SAaFF7QVaNf1l\r\n2/7CkH+aoFV3arHYcmxTnxy1rDtrcxSPDh02c/rwEtRWfUjtvMfvkYSYndp17DhslJDdbrWWYh9F\r\nW6mzSLmKet3hqujFvqgLr7oIqga6VDbm2aEG6lg3ICymCstnlGbff5QWbFlhsgWl9Ycqf6zIOcIL\r\nS7uOfap7ueS9TAVWq/payR9rYebtVg271FGHgmliIbLXHCu1UvahkTfQCPaRwjuMvPXn0oNw16RW\r\nmgYmdXegDg1MWyG4tQzyuv5Wf3/WStxJbOvPwzBlv69Wqm1LaiXsHfb7ll7YYl/SiNXBdvf1pZNh\r\nx8bOUacLupO0vbPtuOhDh0I2y8Vmv9qdkuBsNTzo73c96rS6t9/d6PX6g/BgEVsW+6FBXw3Clf2b\r\nG9D+ld3l/kSXlG9vuVNANqV6oLbo+unVycmhI0wR9D+Cs2mDdqEXv4dMotp96aExSdDo4+J/Py7m\r\nRjsPeBbwAoZRZn5Znfxy/f8Ts428aV9cwAjGP48YTW97G3At5HhucG3nw+5LhUwiASdLQFNqCTB6\r\nkxb6yOEyy5fGuPAU3A5" +
"zpR9MyYHCh+Gv40miMcwciyVyXDkK5JFW02qBbAktQGKdgOtB4dIhbYJo\r\nMvDsmwtztUmO+IE8BiTBeXegpj6ePQbZgYNoMh59SbQxJHJgNH93TR4YUCaRRMunce01G5eRzxd/\r\nya/Zuwh7m6CjhhUg+meCIKKSfOvs8Tp7J+2CMSmUGVRilGgI7XhtwW8YOpOgn/gVA3rAMghK5OJA\r\nrgSJmFWnjdyCga0cGJIZK3nwiU0a4TrLV9epjRDNsLenC0Fai7AHBibXuIugbJxsmJtWYyOHmNkX\r\n1sY9QRtZQBrkytopKjOiCV+u4cRvfRGs/GVMETSC/HqhUlgIZhgV2rCeos6FuJVtRFg0uLawYlko\r\nZyoIWs4hRKZBZA5IZIKhBA/4r7CwMmT8FB1NEJpJUJTncugpzqE5vLFW5+JRzHrCqzgja8DxhpHl\r\nDNAJCbTOhiJvKRfpJsti9fnEGmZtJLk6F7xewMmVHMci5hOUr89c4Clfx3A+boxHc+g9SUQjquA1\r\neptwxqPkczcn8giGolwSxznjQuWKI1kz1yC5lUxlnYPhGI7mWPKEY6AduCnzdAlMqi0Ga5uoY6Np\r\na7NbEBs8jZN1Dkmi6AHfCK6xTSxOYAiK4mgGa8TNOJAAgESMb1lTow1sw3wSJ9bYCI+xXPyu2TDz\r\nLEqcVDgcBcevLrUFkK+b8UYGPUgibAavGDBuPoIqcifxW+r5ql55pOFqqFgcQwx4A2WbvApdybEq\r\nnFlXZVgQjiOnHIerVDiLMuykQnSNPU6ujGpb4d9p5E3mUyiYiELha84rGOgJrMlEGDnoeBTgp5Ax\r\nQYUBRLhXKN5SjssJBtzWRkarkDeZe2JeLlPcRwxlgrtrGhQ+gnmjD5LRTULRTB43DwxNwlgGBRLJ\r\nikzxwo0JAqHMQbBpKpIykAwAwYOfh+FNhU9hIJosdweijJKMIB/WNghqS8z7HubnziQIcgi/f0iK\r\nRfjsgmba4HcR8FcKHm5oEOkNneBQ9" +
"QengsMswE8G8pLT2lNimNeMGwximEpSJUqaQiiIFgSMTk8A\r\nSjuUGUom5a4wM5KMo3BaC92/w91JgOOHGFJtJcwk6OKfjrm50c4/FxrNaGeEOc37y518n54k6Due\r\nYYogZe9pAKkGPw0YXg6P0u+YzzEOjVLckOzDbW5B22xPqJrOleN6F01/S6xOD1vB0FTTETfgwqez\r\ni/QqnHjWv0j3YfjEHDGIEFSLjcahZ6+7W3i2HhMCFAIQnmFObYqgQHbQH/TnQiYx1K95Nkyi26UT\r\nN7fBqLr29hrDCVRrF7ElJaj8zhcxoDrraUKm9GUnvCW6i5R6sL/VMV1UTRrTuVjdKYn+xijVAwqX\r\nS4VSVbJCVnTE9Dc11Y3LvE0tFVLbFDV5qUIuy0Z/43KrrwkvizsuqgPF14TPQ+eQzQslKPa834kt\r\nmbbOhldsHOm2/2N44HVo0q/pHp8RZMN6xWyNsgueQ6qt14Qvobdm6iJUo17L4hUsWtpdXQAV3V9M\r\nxWyh3QbZYRaspXFfCZaU3xWg9LGUN0udizvC/u6UZuhMSCMhQfQehUzuVspfEw5LN1hWXOxidv1y\r\nbEphFlhK75Ix/xXV8og7rXbhSn/Ybhe7xdahw3tFlaj2lbqmOjTXzHk95pqqRLpdXFrEui1d+7Ub\r\nZJqgeduRt9gybxezF8L+JTW3sd3qFDyB88XWled1Y4MvIbTg8VI1XLRlr/SCEL7Mbgv6WEkHjmMC\r\nRWGCere04d/zL2+4a9QVPko0QpXacaQvJYJqn9gwRTkKrZtA2xFSLRZv/JPNoBo+pA45AcuaFlVi\r\n3qVvZXvU9mHWxul6l0Whp98m9flDrnAjxEqw+Emks7GbGkZZXreYN0VQby60uq2/MYVN3qNeSNcT\r\nQ9RS3+9a2u9C5wOjSO9E4cO2ru0Qw6s6tcktqE0hU97T9oihw9S+rtDtKXvu7EC/JKZjS2JoWlvj\r\nFrY2deI+1I3tr+4cdQqOsOApUKs2sxJEn8Cm/2h" +
"bn+qZsurukrh/7r5pq4t6tees0HM79vV90+Dj\r\nzU37aLvr2V/a1E8vaD8zuS2L5t5g99W6TRH0ImxvT5b9j0JVWuD/Ldh+Vfk7RdCHn/7wv4APo+27\r\n8dNYim/3igAA3i9/NZ7S/oZM3sQ/Lu83FGbDeQE+OI542QcBAHz1B3h8OR8hQU8qyB5OS5nNBBgL\r\ngH+jAwlQPQNnOUjhUO8FtnCsoL1/5gJhQotGJ6AxnfdBO4w5PeqZre7Qc2WoFTtVAMmSWPyWhmtq\r\nEwYVcrsGRJSGOlqawOJRIK6PAZGg/FHjCjhOUJVopvxYU3lkRdJCrSFJBdRZybTrqjuYBxRMWlEl\r\nxQT1hkvLVk758RkxtIHJHSSDWgNazqHHEZamCf7AyZVzjVtDY2hJ6wHydZI91v5QOgbZyrXGRjQX\r\nB6VJirnRn1HEaSRIvAIlbBIJ6QKBakgKj9nqDn7ltJI088g8ehDN4WiTnyeRU9Scwbj5XMNoMN9F\r\nMo3bJKdg0QOGXGBQxMkefybr8Rxfjl5xkQWGiueGhvlpA5tETzlrBrfmeBQtJ5I8TvDJTCVqRnN8\r\nRXVwijLofCLHrYD2aERvneN2uxKqcqZxGk/IyDgfj5IntzKZAc006CZ/7OImmxBN4MFr1IoaeSsL\r\nZF6gPzWMbJJvNPlKjoNL+F7zJZzIgHqiDF/HrYTVzMWNLCKpcGa3IJ5D4ggfZxGMi+ZQ1IzXG1Fz\r\nnWNZM0qe8Ax6S9bRu9OTJGdsmFUNtpzJoMen0BHsKRtleRSPu3C+IglEE6j5BG1k5jMoh6AIEuUJ\r\n1FpH+YNoBkEjHBo3n7A8E+WtfFQu16MK1Xg9PrO3lsZ1I6FwxSMoiuMMoiDLikzcwLF1fMoxAg2u\r\nAoeX6pyKX4k6OZ5r5E7QuCuO1aGiLsO/ptlLYBzZOMVQZzzD8KgBzZ1w72hBqmMC41RMjsPRqBln\r\nURxFrTzOq5BTnsMRjgOt5yBxGv+JVfB4HEVQNon/GOGhObeDK" +
"GnmciwoVaqpXJ5BeJw9cKIcyR4g\r\nVtAOUC6DN1g2igDO4jmOryOuRpRkMpU7A9vguSGvQ6yxQQtyikSNmfgpumKuH0fJ+gEDUqEHuSmC\r\n6AiJZnBOxaLzJBp1WjEr9L1cIXkcVXEsSHLwCkGgjGseRUABJMYC4UCCtwlaU8joJnRT4CMUch8D\r\nJ/4qCPBP4fP5JNfgoGEE5TLfvYKOEPcRGeGLlGmwK1cQ9L0C9seEYtQny6DTc+haQeGDqX3ydYMC\r\n5iWT++598zThU5QVxP29QqZo3vsM9xGmOVZv7WlFfu8s0xEDNPeWkMnlCoZoErQhCA9GkR5gCALB\r\nFPcGBeGTg8JlPlguEF1mxA/WCd+rfhJAXSMErZA3QS1Bf+trDtVxswkCMaSnhxz+AU8N6Qf+SDol\r\naRIy/A+OYOcvnQHXXVJtSaFSgmHx90PdFVSxSRhlB/OFsYcHw0SjuKN0EmA0KQ3MHESCxUuppINJ\r\ngMBhQcNEIGNph5YnK+PyPAM4ASWHCenTg6G0ADMJGpnD/d/AxZNJ4bdwoXmq+neF2bdhmiDJwLVS\r\nInHoYAAquzpTapR3KT6eTOooH50WDBVT0iopCCUI1QwLEzeUonJcXdCZqyphQaDszQuNlEJTHUCv\r\nfp2pOQYwE7gdqeUejQQ9hM/CyJXgM8NCT5giyH2Z3VLOBc6VmjOlbgCSneUd1a0dMJYbzMEqhOyd\r\ntKZ7rgFVG4A6dS5edyJRaJnPQG06So1/VXO5BbkJU3C51valHgS2t5SawLKmmhZWQTQwIr707FCP\r\ncrq7+vbAn7JciPlSL0ANYkei6EXypXOvI1wTJnQ3Z58+hL8AMjd2jjZE5VlbPQCcKrfE6qfz9Jc5\r\npQhyB8wDJsDuNA9e6uPGQEx3QjDNy5gkqEp1dMqASm8pCruCw4Ytn+l3zTHMfyQWaoIb67p6X7ot\r\nu2COuRyLVJdqufQ71KS4T4jpzeFi97BVOqpRbaFfPALiuLxXDjGwJYaK7U9" +
"7flU22+/qLx3bGFRr\r\neFPhy0cp7XnBtbyY2vkIiKY83o9eh6g8dHhV4aJlca8wMRHs7NPSIh4qOlp6l2URa19124eULtBa\r\nFq+O8l+Uu+aay7PouqFceSw7rZcTF7Mbu1Rqp2Wxl0qvKDymCKoNdvUBTCiqbqjBYftqPi1sU1gX\r\nXL9SiCpgZr9Fn18KbPlL/V1V51C/kyq4zgOvKENiGFS9HS3qYtSgdmnfLYm1QaCY7YmB1Q3vLqp3\r\n1zCB0vmF/mUbLnzecWj2XY9C6ud2Wstes3sJrqc8WvyYF8TYF/yrt0R1Mc+kSjEtHFJCd5fL7i/s\r\nFds9ff4w5W19LOxVhRqIfYhl3SX9lWugLwo3z5SiZ15KCJViGBU48s6PwqYwdYvt1wRdQG/pBUw3\r\nym6htFotXC55HW6PuFMrLVJLMc9id3n7ckk3sOQvTToT+NVeW96r2/LaKbun19ctlnQ33csj0VbL\r\n9oSBGD4052tH3m5An+rVsjcDi/2y/VEMlHqL2UfdPWgmS9vCx8VlcZfq+x3bAY+4sX3kptR5oR9w\r\nTJS4ubTjuclfmnUhSzev7xS6lj1bL3a1XL2xLd3c1LI6dVcv9PRYj1q9mRZ157JXpDwxypL/aHtl\r\nSeJ0J/0a3LXZbgx+G0LD3vsJ6eE3iNEXlW/GWWHqxg/pJ03nPaLaHu28hkmCRq8CL6Az+Gb3BN+A\r\nZ28so4Bf+2L2dXAxmePGq+I/d6Ew2cwmCXp9FRd86/0vAnzlHsfr4j970Z491LhPDId2DwXIR3OO\r\nHo610EDz8/JfhDYB401NWpKQgAs0R/svA2poJBvWIJfh1DJobgdOWoNLOyeHn7/eK8Kjsm08zWyC\r\naGfcBziKnkJT1ZIHgwNoXSdKSMdgzIIcKMCAkVEkXtdEjUAb47JIEGQAZ6clQD21cD4dkEgus5Yj\r\n5pmzQ+SKZnL+Osc0QYlxn/NAkWNokIqw+miFVWGwjl/3J68IoIAmoW0SUnkSkVBjN+NSy" +
"BW5+QT0\r\nngBHxKOw2QT9QLJWX9JKJzHGWPFZg2uZRiWCBCNWZt5YARJqT08OzAdmglGYieTsRXGJHGrVkmUP\r\nx4OsFNak9c5QiVibuTItlxn5F83TPyFhZlkVySnIcgJDIvV5Jx5MOHGUyCDRHN4gHhxaQkheEawR\r\nrmlVPHhFIEBBjMJ6bIgHiYPI614R7hMZtsmYFYYKwSRHBtvfIOgzL1flGiq0wbMIi3LHETT6E5qD\r\nrg14lK9gXGKNvc9An5UoEiFPZhq5/8zdRSPsreEEzTVYOAGLxHGey8T5OzmdQ+WuMTNkz/FZxaB4\r\nnD9wrkT16DzbYPh41IijURLqORtRdnxR77rqRa8IzBeOZWd7RbjXnqIGHGk4T9gMxz/MzZrdgjIr\r\nGIfksLiLj5Mr2MoaZ2X4JM8FSQ4aSsNvP6MKno9neGzlFFt4/dIAJDKIATmIGngWjZP8ATRrd0BW\r\nMgdoUB4xcvM5dCZB7LGRCxpR50FCkYlHsHKSi5IIirIKkC3Kjxv/lytOMckrQkPyikC+3ysCSEuQ\r\nHGfl+fcbedMqSESRi8tySBB6RQlqCbZiUAUNCJMkDAxyQMsZmSGDMvMEyZjjM+dhyn1knDymI/OR\r\nZG6FIBiCcMYNwYiKQe4iJGNQzZwEmjAf5AhC1SSDa864gqw0VWXtNSiSrSSaqnlkogVJXhEOmJFX\r\nhDLTZKBXBCaJMJJXBMOMgugkS+CNIIjPEI/xZhIkvwOd1a32/vZW8oQgl4GOGfZ2WqhNAj2fTEbL\r\nEs5j6Qlz+7KPgkeA55cMGnm7p0FWUHEl2YZLyIOg/jDTUbSX4QvCj0j3QTn8inMLvyfBpxicmCyV\r\nPJEYSgoEnPSKALvnt7wiSEbe4reSixsg2ihs5nexd3kR+HW+Bh7xvtTDWL+xpPdI+txfw3evCN+E\r\n/2WCXhlFv4hX404RlI7pp9Q7oQvR/ajQyD+pNqqPCsPX4B1Gtl2O5pyE3F3wN5wSd1bzr85XGiEE\r\nv" +
"SJ0ByaQi9CJDb0ibOu3xO5WYSkMvR0+oerVz0FjUsMj29hqsm1QyIP/1ZcRvnyYF/Rerwh+T79T\r\nMPdXt3uCXd92pGO6YlyMrVYLuryw6rb7Xbp9ag/uZhe/qPUm74whfnp3SafUSWtX8w6bw9Q25QUQ\r\nfKiqfppPB97wPFFYDmTT2CpUdyylseWhV4SuY/uLqVXq2GA+jwgXlzdjH6m+3mT3iNWAWdk2FfZs\r\nwmDHoRvETJ+WvI7XdJ6AziLl1ruz6th7vSJUKfFQSO20PF7KEVgU2hQmBPbEwnk6gFE3l9TXWKpW\r\nGtRKN7ViSW8PtPS1GcbwvJirC109xkrmw4/eK73gDehFcRGjAthR2PFGC3ryirBd89hKg0W9bcl2\r\n2HK1LIIwsE8q/2xU7xCNFV36SxAbw3qu3uGNEG4JX2tLuyV9Fyu9pk0FSV3f6hVhUX9oF/RdytXe\r\ns/dSXntpb/FIjKkKLT7bF/ypwqpe3263+wLl2KdigtqLvnp1qpQncHN13hcLl9m2ehdLHQoxfV90\r\nB1r53WzR/LrQEiSvCLHVoVeEHegV4evXfX2qewWkq5UmFmWmu1SghbYDgrpQEgupRYc/Wyjp23ZK\r\nFxOKqkLbtfT6XWYDEdU1ySvCOwkSt1fF8LK4P+hcdDY2OmL/HBpl6w3Uys7XzqZp6yt0UCDtagYb\r\nps6zKbljUIpnna2vSpD6oiMO1CH1Rgf0P6II2k61Pzbb+EW4P551xM6G5ULcV4umrU0TuBChVVE8\r\nE/tbod5EC9KYBpq+slM1dfpQMS8O+hv9ubRJTPc7G/2ttDL84vzfIc56yjONUh0yqTtbr9A4TdB3\r\nTGGSoJ9++I7fz3pRhAZiRm/cANL+Y8C9ZCUaQjJBNjr7+os8HNeMBmvDtI9xpRUucPuQ4XMMU0kY\r\nHsC8wI6UIfjzKIuUyzCjUf6PucITo91XISWGGB0DvDEFz6eAcwbgt38w+gdb6IhAOr6/h34S4A6t\r\n8N3DoRkMlkl" +
"nX9RJyRR0RAH+3IOfHOQqv3/ICZ4BEUA+L6WTAFIpaPBPKhLIBKSIAFYjChAuB+VH\r\nRvWCmJBFnoCW5SR5H8Iff1LoFECgVMrTmZmD1cQphwZloEo+GRG/JZCE784Y18oVoNREDifuwY4v\r\n8Zmd/6Fevq4fK2j6tAHOfs69oPjQJjkrcrKCNAx8PJrEWbnimr2TA+EVCRKPZ4Jrcpp8vsByBG3S\r\nChUq8VP+wHp7Dbb4fI4LJq7ZEyt24MTLFApYH0IOBPHgdwpaK0m6HjcQ9z4tqPP6SEZQG4VMq5AB\r\nvuEMnQnQRINGchzT5J6G/DMJ+j1fZk5xBEeMXObk1sBGndC4Fokj2HyUahAomoS/k/Lap4Zzocw3\r\neJRHzDiy8IJ7z/uEsxHNHCfRKLS+X0ebeBxtWPEG34i66ogLZVRsvfKaqmZNxeDz7Dwa5Bn2OIIz\r\nRuyYYo+bx+vsKV7OcT4eedSCya8XVvQnTQzBUD6ew8kFhOR4BsXLawtx8wIIR7mKnjPyHCiba0zJ\r\nSRvQtQxUU3JPtuFmErTGBzEU4VGEPEGRqIFNkHVugak3rOhKNIOSceNJxXnCsMznDM+hca6OGhZW\r\nMNTKv6BbpJMqOokkjNw8e5xwspkGxi00MlyOO45myAyqwjIr+tcmf0GFWRPjDGiZr5BlOoKXk9wd\r\n2TCXnfGEAT82o9onhaQ8wnM8asZw9nSB+cKaWTMW1+MVsrKOghNmyRuC6gQrZ3A0x03bqKMJfp2/\r\noxp4/Ul/N/sWS3Kc+SDJMxluBT2O1EGNGmSDZIlMPGqGM9YYnmV4rvwZMYN/GBpvkmwOLauer7W9\r\nT7jwinM+kkHADZVI4g0SU+VUOZ5BjuEthjAcqFh8wkfBGBIkQzaSmNUM15lekw0DugKEiiZyZZAh\r\nwx84nxZdy6/juXgWykKwDQSNsCRyYDazdWb9IdzAonAuqRmU/cyIH83iK2aeja+zj9d4JkG01geN\r\ns/lANBo8rXwKaWUlDbpG2" +
"N2BIC34wa5VmvDlA70h2ChANzrKfBxwgSnomGF3CztpEBv0mj7p1pDs\r\nXsIn5mvT42iCAdF9oCuMMLATAd26wgdXdYKemPbBTgWmHgHKIpdkAZKCRwDIW0Fyx7CIkYwymsig\r\nt8OypwB6JpAlVJeNAt7og0Cmn+Wf6c9gQ38GfwE+g2LggRwej37wAESj5Z+hBk8KeQZ6DZyGWa2B\r\nLNdgRCkuDFuDwTA5OHgZWpBIirL2e7h9KEPKcLpAGAjJeJAF/F83+ECJT+FrCsM9FGOUYgxSCiDH\r\nU4b3P43IGGKSIFHzv4FnNfmWqklEPGKKoO+YxhRBVa+jU0iJ7uzgzP7RllWr4WLQfTA4rC4OretU\r\nv0rxHjBjjV04e74NxolP2rYH80aaxS7Ys4yOwvqntWJP01PSau9H9ZwYtm/tWzbyH0GAfRDqzu04\r\nNNuTug6AcPsN5dJLqJqeLX49e3EV1RRBhSPTtuC3Cz3Bn92qedxmkboQA1kgIOVf2vHs3/hL+5bB\r\nINzv9i3KvMX9RWl5zdR3DEnXVGJ196jf6W9bALvUxWZhL2yZS1OxI4v6ctBe3k6JIaqntqXcSyG7\r\np1NoKbuDHYmvxY/7l5YlMeTN+lsf90tzYtp2KXTtu55q0Srl/oTQpY46CpkGPftyyKLsvibOFDSH\r\nykDPMvCmNvJ77nZvq5/umqiw5bmaapKgKiXWdFeqRY8Y8/h7h1n3kSiIoVbr3LJ/VfJiJcqx6LBd\r\nXeq8AZUbEy7beiGGqUZpp7FNWexLortYsrf9RQzILYBMA7Xs3GZR0O2W/JSJOnSIO0vbwu6S9yqQ\r\nDVA6qoaBA5hYr9l2hMygse35XXs7qnBX3PHkd4X85bltevGk2yHaWn6sfWi/bBX1rVfUOs+wI+hb\r\nLUrQX2KlMKXvty8xSt/79FxDOt2CHLt2e6FLWYT+IlU7crv2dnWxbOBIGdZ3D0ue7ZZdXwM5Her3\r\n/FjpyJYV/Kopk2KPCEkOCPyOmuWLqZh" +
"Sb4m7Or9FcGPLm67OYrHlpyx6G7YVurS0suFdjNqLUV1X\r\nTVj1tuB91nZjnn2HGGP3qYJZVzpXelurIf/Sfm0ZTiidQPrQQpmwgLDYr7kctteXDk5hc8Gze7Sz\r\n5HVRpsDRonAZyLopatIJioQpgjR53YZycxC2dEKWre3uIO9xW/agK+DqoKrure6bzkx9XafnCXVC\r\nuoEyrTQpd15T3u9LdiTV4uagL+57BkrRbVFCy4Wa6kBM69SD9M3WNiA33B2ENO7eoAMCVjdvlENt\r\nmO3GsgRu3u3uanhp4wYEhbum/Z5o+wj9F0wBLqZVKwfKjUHoRvnmp4RH9DVhnVIZ6ujUtiWlDhQ9\r\nGOzrnisApwj6jwF4FnzbIut/FiYJ+rVuO/+XMNsrwpiaBb6zw5f70dG3AiQd7QEMX+QnsoKKmNHu\r\ni5D0Y5IQUAbJADVIP+VC9BWM6S5G29fwKNLTHLPZo3mog5PGBHAIFgnKtZEm1DqBAFDqN5El90Hv\r\nBzCfe/l6E5YvI6AYUtZAoIii2XxdYSb3NcFgDDpVVRAyIEMTKsOaWp8iEQHho0gPAKSN8gVjKlqu\r\nXQMFQU7hRQKMwnNQ+mGlRmlGAKXAJLScaD6MC2cS9AN57KwofPdNmaJJK5hywskhPrCniCi0YDO+\r\npOstgDF7A9RQEQTFGxtagk7kcFYBKqjwgZG49hSdz528OnXn1mgl0WYdDv1dbARfOcWZRCKHWVWc\r\nFW0Q9YkZLdpT7FZO0E0fEFkmk0VkTivja8rkhC/hxKM1lA6Ci3EPzhGSKnP8oiSSOHoXUQRlRNPA\r\nv2v6S5RvQJeSKqxxWjfjmYN1/jZ6Wo/jGQ511lFs5QW92GtIZNgGySDJOvMDi6EkH4/qEdSMm/kD\r\nlj9IJHh0PvqkYpjGGnu8zslQJlcBEjWxShIjIgbAWDxZV2FBbkJLkkC4ebKRQ5MZFLGaSQyUhmSw\r\nBsmhUeNC+VMjiSMYSuAIyTVYXFUfX/mZcJ6gJGesH" +
"7g45N0EcUjmhGN4VZ1DcvHP3PE6NPLlXGHr\r\nqJlkxwV7A4nMCcJaefIkvo4aMDSCRkncwNZPKh7UwAKCEO709WmKn9lgZj6aYYygjWXi63j5lKtY\r\nUQZHzHEnfuuaWCB9fVLn+ChfdiJJPE6iB2zG6uIZjCPQqBOtoyqyjq2QKFZnDVw9nplwI5pwsixf\r\nIU8aJME/Wp2bfYuZ706t4EoQiIpDKslK1IjFSQ45OGVyQD6y8Q0Eac1NRDJIV0mQXDzHMVFj+YcM\r\nZ8WBtFZr9JQ/SL7uAiOBIJLzA7L8+xxKqBADupKIOjkC3HfsSjQ3fotpT1fWEIQ1ogx044CaGbNV\r\nhcQJUDYXPa2QSTPJI4wT/DFjbA4xTiiHtac4Yi2TPItbEeShac0kCPRmsMuCP6glkcvg3DBpD/SM\r\nctk38ANdFwzzgd0l7JyhLwOajporCbpJSB3jk5JqGvLmPO2T0euVO5iPDzpCgA8PmBvYAxmNA+QN\r\nwsD2QXT4SyT5FSC8FqYZBjjBpQJJx8uEvTs8Sd+P9fyzW9DIMcA/EdCpwXPHBtMYxfgN8lxHEqO9\r\nESKKqYBX8Hmmwuw7pvEWQW9MMvjfxxRBSk1aqVRq4NJV25JmIC5mwaAOrug8U4vv9ocwgntqeZam\r\nt3p2M6GNePKal7ZIY1T3w/U4U9o+glFp2nIeTs3ZoIpocBHuacDY1/1MYbYP57eAcxCjfF5AdXJp\r\nFRgxT7shrPZGOxOYIkh/sWMptLfERVX1ULC0vdlY6sqaXwLDa656mOqETRs9W6uzs7ype2MGFJw7\r\nd5PWdUym3rlbuW/aXhXPdK7VvApktRxe+moCNUpfrQ7OlOCMmKa6q9uraR308iohf1Pc2/GIi2zn\r\n8ChdhBrFq4+hwMfQSW/aKYIYauk2dMrLrV4H5JSn4M7+Tcek3l9V9qq9rX1dqDjoDQJHvfNNpelx\r\nsF897Pg/9jZ6JtF9vn2zujE464UvQyOaxzFFUK10lbK3P1RrruW" +
"iy6SnxKrQpoQlndLv8hx2s/mr\r\ndsmNdrv6mupNgiiNGC6qWt1W7OqyuFT48kFM6+fcDnEnuy0s6kuUR/S62m0LhXEXItSCLWKBp1lM\r\nbWXAHHaI7kvPIqX2Z9U6zaInfejxX+qnnSKIZ7Gj0C4bq11RgMgdzBy7ElxdodjFWi7H4hVV0meL\r\ng1qp1j3MgrIkZZMEr13vwgQqoL8q7bf0/bb/qpR1f3q+LnOKoMBqwVIIfNxpHWYD+hRoP157Nryw\r\n1N8uBkql3iV1tVSz6wtL/l7xNT3ZI/xH/ViLc+wfLap6Qtj15Tzd+mhzLYtex77KRjnyR9WivrXI\r\neVs65Vy4ZHK7sNJyYBXc4DBx7EPYZXKImzuC0p8aHK72xdhSOCYcLgh2YVqVvH1Y2+WEYnZvkRXz\r\ngr6VNV3qKLOb07ldLcGt3xb03l2uYBEK6GLp6S5KL6SKlvySt6jyxJYW7bXDrO1SuHqub5siqD8X\r\nVqttWXAD9fpnuv5ZwTG3Le4si6Fl0KXYz3csfYtyR23f27e8qa3ZLKT2uz11Wr1pX+1veC1z6Vi3\r\np0+JZ4urbodyNTw4M4n7fY/G+7F/Ibr16rzF1OkDSErlfM/+ceejuN/e2jnaWIR90L7S5rgQ+xuL\r\n0xr6s8JSuOvph+2D/J4Y3trvdcO79kG/6vW4U0q7uq9c7fUsnvBNP/TxbNyjws3FtmUw2B90+4td\r\ntV0XAlF7U7MfIaYI+k8BNM2ZHu1/M6rTxgB/CyYJktwC/PfjHR4QZmCyd50kaNbCj/8vmD3DbDQe\r\n+UdAnkiMlIYPxvaHR2CMmHim8/oPwsyx2D+QINrHsgwRBFzQkUwDcJJIrBPaBPinNXMMcictbnpj\r\nae+/Bf8qghKZuILJnKxEDhLogcLAMiTrXCDYAzIezeQ4dJ6dJxunr6vMvhVv5/PekmYTBAf/o4gj\r\naJ8MHA5PDY0ojgAVDXA52uhwDGv83QcSRUh05TMXjV7hLLR4lsFRvBzlcWvGe" +
"oLk4s6F15SucD0c\r\nXLoMrQjC1dZgD5YL183B3fFpo+D0aA/g4W6eAAyCvn5fADTMCBf6jYkxW91hPT6dh/IASbSwq6C1\r\npzwC7gawI1kcBDvmYAKuu4YhdCIyr41kEMPxKGRUBkQix6+oEPT05C5BolYXyzSMKpTlkuxdIjO/\r\nhnJ1Hk9ir2mlaUMSjTf5SpJlKtp1HiGwipMr01pjg2DjTqwRfVrRObKjCP5DO4qnOHIriTKqBPz7\r\nmbmjE4YmAz11TtEnj8Q/W5M8E1E9nZhJ0E9ohUIqp1AzjrJODCEO1vmyzMjHrYZ4BsngpxwTZREe\r\nRecz0Ogcg2InUScnXwANheGsmaGj0hHoU0bhI3KNhJxOzq8noa8CQpFsKoBUsvtIkyGS8wTzyneN\r\nBGnEgyorepw5YO8i9bKTozMNuTyCV05x7jYXJxYeCZLsKGasaHJoR7EBd0i04oqTjRycYQuuzgJD\r\nrlyhyMrplITwQnBrGT4edeJPSsqZBEV5rq5CzCiiwhmQEFQ7gkY/cxGeZTGGROMYB839ITzCooY6\r\ncoqhxkaUNoO7B0liDQpnxy34wTaX0CaD0PgC6JrhTDoaLg8F9wlU5A2b3Mv8wEmccK01SoBSy/Ik\r\nVs6higxizoEbVQX2mvjJ06xI+pR/sqNoXmhwHMsbMC53kmEbHM7yZhQleJy1cizL4UMjmI+gDWgU\r\n9WXi2EnjUVc9uwWpjp1xHmsc6FkWV82fntyuqcCVQeNOPAmaFJphy1FSdYAYERx0KRkkTnC3BhZl\r\nGyiLxI0TphAT4J4wstpc/O4auzNwt/L1SgKQZuSsyVGMGVhj53OsmUOsaEV17MuhBmkeZ+Ia8oMa\r\nGnIn/kjQgx1F2KS5qPOA5FEDEA4xYNYkxvJM47SRYXEOYVU5NDkhIYB8necRI8qzBv6RudmdtELm\r\nu2+WfT5fhOWO5WQc3B9M8H6eVq1EDUG66TP45AqFTyEj+HICGiGkmzIfc7wehKYUacP4fPI" +
"Ehd4Z\r\nuVOc0UYWKoETgrOaWe4gmmmM3R6vQnt6YDheMwBRmlatzHDsY+RNgr6nFUSCUNwrQJ86VtKjHUUg\r\nnE8mUxgifBl6TAHQGqANxwi4t2Xgp1ibkBCCVjB0ZN4HJ5qPQt4gSPoWSoP/EXNZu56EqcCRdr0C\r\nVe9QLQ5Yh5ARoPsHDxj4pRJGH+6Ply5XkI3PqBPlyxGe51EzjqGoEY3KSRT8GcV5HaAkqTjpUygs\r\nYPgIhVsgItgZRpMA9e7wswJMAmWj16GXfBAMU0sBsEpwDyaeAsgRnhrLcDZBo0ggIXx4PnURU70/\r\nzPcN0KfowTUbgX60ETZOsjiqQk4bUSePoPGRH6Z/Gn5T9u8k6DdDrmjCrymKY8l5tUwWlAY6MNQX\r\neW169H8E/lUESY1XatSwlcN2DiG1Z7D5D4Zs1meff6YZrv8aTOqlJwn6jmf4TtAb+E7QG/hO0Bv4\r\nTtAb+E7QG/hO0Bv4f03Q/rK4Ib31VKXPudKH+9CUJYv/zwSlLTeruot0fwsuiBE33Utnao0Yyk+u\r\nZvj/TZCu373R6ZbEzZRYvend5Nt7otIyuV7o/zVB3S1bt6vb1nU2LWI1tW/perbEQX5yxdn/Z4LO\r\nlGKoN9jv9gbQqQDYDZnmxD70uTmG/9edtATQgEZ7L+I7QW/gO0Fv4DtBb+A7QW/gO0Fv4DtBb+A7\r\nQW/gO0Fv4DtBb+A7QW/gO0Fv4DtBb+A7QW/gO0EzIYr/B5SqkQzX5PWvAAAAAElFTkSuQmCC");
            this.ReportName = "StiParametersSelectingCountryReport";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.HundredthsOfInch;
            this.ReportVersion = "2021.3.4.0";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
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
            this.Text6.ComponentStyle = "Footer2";
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
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 158, 158, 158));
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
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(570, 0, 179, 40);
            this.Text20.ComponentStyle = "Header2";
            this.Text20.Guid = "156dc5f28b8946c6828989624919731d";
            this.Text20.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 158, 158, 158), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text20.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 158, 158, 158));
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 570, 40);
            this.Text23.ComponentStyle = "Header2";
            this.Text23.Guid = "7123692fb8e94f07b593c2c773f9f7e5";
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text23.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 158, 158, 158), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text23.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text23.Indicator = null;
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 158, 158, 158));
            this.Text23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.CanGrow = true;
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 40, 570, 20);
            this.Text17.ComponentStyle = "Footer2";
            this.Text17.Guid = "08478f239a3c433e8e935725529a41a4";
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 58, 78, 94), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 158, 158, 158));
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.CanGrow = true;
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(570, 40, 179, 20);
            this.Text18.ComponentStyle = "Footer2";
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
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 158, 158, 158));
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
            this.Text11.ComponentStyle = "Header3";
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Left | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 77, 182, 172));
            this.Text11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text11.Indicator = null;
            this.Text11.Interaction = null;
            this.Text11.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 210, 40);
            this.Text10.ComponentStyle = "Header3";
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Left | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 77, 182, 172));
            this.Text10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text10.Indicator = null;
            this.Text10.Interaction = null;
            this.Text10.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(380, 0, 130, 40);
            this.Text12.ComponentStyle = "Header3";
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text12.Name = "Text12";
            this.Text12.ShiftMode = (Stimulsoft.Report.Components.StiShiftMode.DecreasingSize | Stimulsoft.Report.Components.StiShiftMode.OnlyInWidthOfComponent);
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Left | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 77, 182, 172));
            this.Text12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(510, 0, 150, 40);
            this.Text13.ComponentStyle = "Header3";
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Left | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 77, 182, 172));
            this.Text13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text13.Indicator = null;
            this.Text13.Interaction = null;
            this.Text13.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(660, 0, 89, 40);
            this.Text9.ComponentStyle = "Header3";
            this.Text9.Guid = "25f1f4322b0b4ee28b083c644b29a683";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Left | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 77, 182, 172));
            this.Text9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
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
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 74, 74, 74));
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
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 74, 74, 74));
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
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 74, 74, 74));
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
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 74, 74, 74));
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
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 74, 74, 74));
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.Character);
            this.DataBand1.DataRelationName = null;
            this.DataBand1.Interaction = null;
            // 
            // FooterBand1
            // 
            this.FooterBand1 = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 280, 749, 10);
            this.FooterBand1.ComponentStyle = "Footer2";
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
            // StyleHeader2
            // 
            this.StyleHeader2 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader2.Name = "Header2";
            this.StyleHeader2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Bottom, System.Drawing.Color.FromArgb(255, 158, 158, 158), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleHeader2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleHeader2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.StyleHeader2.Image = null;
            this.StyleHeader2.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleHeader2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 158, 158, 158));
            // 
            // StyleHeader3
            // 
            this.StyleHeader3 = new Stimulsoft.Report.StiStyle();
            this.StyleHeader3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.StyleHeader3.Name = "Header3";
            this.StyleHeader3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleHeader3.Border = new Stimulsoft.Base.Drawing.StiBorder((Stimulsoft.Base.Drawing.StiBorderSides.Left | Stimulsoft.Base.Drawing.StiBorderSides.Right), System.Drawing.Color.White, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleHeader3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 77, 182, 172));
            this.StyleHeader3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.StyleHeader3.Image = null;
            this.StyleHeader3.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleHeader3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
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
            this.StyleData1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 74, 74, 74));
            // 
            // StyleData2
            // 
            this.StyleData2 = new Stimulsoft.Report.StiStyle();
            this.StyleData2.Name = "Data2";
            this.StyleData2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 255, 255, 255), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleData2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 224, 242, 241));
            this.StyleData2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.StyleData2.Image = null;
            this.StyleData2.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleData2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 74, 74, 74));
            // 
            // StyleFooter2
            // 
            this.StyleFooter2 = new Stimulsoft.Report.StiStyle();
            this.StyleFooter2.AllowUseBorderSides = false;
            this.StyleFooter2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.StyleFooter2.Name = "Footer2";
            this.StyleFooter2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.StyleFooter2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.FromArgb(255, 58, 78, 94), 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.StyleFooter2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.StyleFooter2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.StyleFooter2.Image = null;
            this.StyleFooter2.NegativeTextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Red);
            this.StyleFooter2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 158, 158, 158));
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
            this.EndRender += new System.EventHandler(this.StiParametersSelectingCountryReportWordsToEnd__EndRender);
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
                        this.StyleHeader2,
                        this.StyleHeader3,
                        this.StyleData1,
                        this.StyleData2,
                        this.StyleFooter2});
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
            this.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiXmlDatabase("Demo", "", "resource://SelectingCountry", "", Stimulsoft.Report.StiXmlType.AdoNetXml));
        }
        
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