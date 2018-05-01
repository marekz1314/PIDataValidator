using OSIsoft.AF;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Data;
using OSIsoft.AF.Time;
using OSIsoft.AF.UnitsOfMeasure;
using System;
using System.Linq;
using System.Windows.Forms;


namespace PI_AFSDK_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ConnectionState the system picker to the db picker
            afDatabasePicker1.SystemPicker = piSystemPicker1;

        }

        private void afDatabasePicker1_SelectionChange(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {
            AFDatabase db = afDatabasePicker1.AFDatabase;

            //clear the tree view
            afTreeView1.AFRoot = null;

            if (db != null)
            {
                //set the root of the AF tree
                afTreeView1.AFRoot = db.Elements;
            }
        }

        private void afTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AFElement selectedElement = afTreeView1.AFSelection as AFElement;

            // Clear the attrlistbox
            lbAttributes.Items.Clear();
            if (selectedElement != null)
            {
                lbAttributes.Items.AddRange(selectedElement.Attributes.ToArray<AFAttribute>());
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            //Get data for selected attribute
            AFAttribute selectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            //Get some AFTime objects
            AFTime startTime = new AFTime(tbStartTime.Text);
            AFTime endTime = new AFTime(tbEndTime.Text);
            AFTimeRange timeRange = new AFTimeRange(startTime, endTime);

            //Make the data call
            UOM desiredUOM = cbUOM.SelectedItem as UOM;

            AFValues values = new AFValues();
            if (selectedAttribute.SupportedDataMethods.HasFlag(AFDataMethods.RecordedValues))
            {
                values = selectedAttribute.Data.RecordedValues(timeRange
                                                                , AFBoundaryType.Inside
                                                                , desiredUOM
                                                                , null
                                                                , true);
            }

            //Populate the values listbox
            lbValues.Items.Clear();
            //clear chart
            int ip=0;
            chart1.Series["Series1"].Points.Clear();
            foreach (AFValue value in values)
            {
                string s = String.Format("{0} \t {1} {2}, Questionable={3}"
                                        , value.Timestamp.LocalTime
                                        , value.Value
                                        , value.UOM != null ? value.UOM.Abbreviation : null
                                        , value.Questionable);
                lbValues.Items.Add(s);
                //add data to chart
                chart1.Series["Series1"].Points.AddXY(value.Timestamp.LocalTime, Convert.ToSingle(value.Value));
                //red Questionable
                if (value.Questionable == true)
                {
                    chart1.Series["Series1"].Points[ip].Color = System.Drawing.Color.Red;
                }
                else
                {
                    chart1.Series["Series1"].Points[ip].Color = System.Drawing.Color.Blue;
                }
                ip++;

            }
        }

        private void lbAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AFAttribute selectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            //Clear the combobox
            cbUOM.Items.Clear();
            cbUOM.Text = null;
            //If no attribute is selected
            if (selectedAttribute == null || selectedAttribute.DefaultUOM == null) return;
            //Find the class of UOM
            UOMClass selectedUOMClass = selectedAttribute.DefaultUOM.Class;

            //Populate the combobox
            cbUOM.Items.AddRange(selectedUOMClass.UOMs.ToArray());

            //Select the default UOM
            cbUOM.SelectedItem = selectedAttribute.DefaultUOM;
        }

        private void btnValidateData_Click(object sender, EventArgs e)
        {
            //Get data for selected attribute
            AFAttribute selectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            //Get some AFTime objects
            AFTime startTime = new AFTime(tbStartTime.Text);
            AFTime endTime = new AFTime(tbEndTime.Text);
            AFTimeRange timeRange = new AFTimeRange(startTime, endTime);

            //Make the data call
            UOM desiredUOM = cbUOM.SelectedItem as UOM;

            //Get recorded values
            AFValues values = new AFValues();
            if (selectedAttribute.SupportedDataMethods.HasFlag(AFDataMethods.RecordedValues))
            {
                values = selectedAttribute.Data.RecordedValues(timeRange
                                                                , AFBoundaryType.Inside
                                                                , desiredUOM
                                                                , null
                                                                , true);
            }

            //Validate data
            float curValue, LoLimit, HiLimit;
            LoLimit = Convert.ToSingle(tbLoLimit.Text);
            HiLimit = Convert.ToSingle(tbHiLimit.Text);

            foreach (AFValue value in values)
            {
                curValue = Convert.ToSingle(value.Value);
                if (curValue < LoLimit || curValue > HiLimit)
                {
                    value.Questionable = true;
                    value.PIPoint.UpdateValue(value, OSIsoft.AF.Data.AFUpdateOption.Replace, OSIsoft.AF.Data.AFBufferOption.DoNotBuffer);
                }
            }
        }

        private void btnClearValidation_Click(object sender, EventArgs e)
        {
            //Get data for selected attribute
            AFAttribute selectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            //Get some AFTime objects
            AFTime startTime = new AFTime(tbStartTime.Text);
            AFTime endTime = new AFTime(tbEndTime.Text);
            AFTimeRange timeRange = new AFTimeRange(startTime, endTime);

            //Make the data call
            UOM desiredUOM = cbUOM.SelectedItem as UOM;

            //Get recorded values
            AFValues values = new AFValues();
            if (selectedAttribute.SupportedDataMethods.HasFlag(AFDataMethods.RecordedValues))
            {
                values = selectedAttribute.Data.RecordedValues(timeRange
                                                                , AFBoundaryType.Inside
                                                                , desiredUOM
                                                                , null
                                                                , true);
            }

            //Clear Questionable flag
            foreach (AFValue value in values)
            {
                {
                    value.Questionable = false;
                    value.PIPoint.UpdateValue(value, OSIsoft.AF.Data.AFUpdateOption.Replace, OSIsoft.AF.Data.AFBufferOption.DoNotBuffer);
                }
            }
        }

        private void btnShowQuestionableData_Click(object sender, EventArgs e)
        {
            //Get data for selected attribute
            AFAttribute selectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            //Get some AFTime objects
            AFTime startTime = new AFTime(tbStartTime.Text);
            AFTime endTime = new AFTime(tbEndTime.Text);
            AFTimeRange timeRange = new AFTimeRange(startTime, endTime);

            //Make the data call
            UOM desiredUOM = cbUOM.SelectedItem as UOM;

            AFValues values = new AFValues();
            if (selectedAttribute.SupportedDataMethods.HasFlag(AFDataMethods.RecordedValues))
            {
                values = selectedAttribute.Data.RecordedValues(timeRange
                                                                , AFBoundaryType.Inside
                                                                , desiredUOM
                                                                , null
                                                                , true);
            }

            //Populate the values listbox
            lbValues.Items.Clear();
            foreach (AFValue value in values)
                if (value.Questionable == true)
                {
                    string s = String.Format("{0} \t {1} {2}, Questionable={3}"
                                            , value.Timestamp.LocalTime
                                            , value.Value
                                            , value.UOM != null ? value.UOM.Abbreviation : null
                                            , value.Questionable);
                    lbValues.Items.Add(s);
                }
        }

        private void btnShowValidData_Click(object sender, EventArgs e)
        {
            //Get data for selected attribute
            AFAttribute selectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            //Get some AFTime objects
            AFTime startTime = new AFTime(tbStartTime.Text);
            AFTime endTime = new AFTime(tbEndTime.Text);
            AFTimeRange timeRange = new AFTimeRange(startTime, endTime);

            //Make the data call
            UOM desiredUOM = cbUOM.SelectedItem as UOM;

            AFValues values = new AFValues();
            if (selectedAttribute.SupportedDataMethods.HasFlag(AFDataMethods.RecordedValues))
            {
                values = selectedAttribute.Data.RecordedValues(timeRange
                                                                , AFBoundaryType.Inside
                                                                , desiredUOM
                                                                , null
                                                                , true);
            }

            //Populate the values listbox
            lbValues.Items.Clear();
            foreach (AFValue value in values)
                if (value.Questionable == false)
                {
                    string s = String.Format("{0} \t {1} {2}, Questionable={3}"
                                            , value.Timestamp.LocalTime
                                            , value.Value
                                            , value.UOM != null ? value.UOM.Abbreviation : null
                                            , value.Questionable);
                    lbValues.Items.Add(s);
                }
        }
    }
}

