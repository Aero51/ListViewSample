using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections;
using System.Collections.Generic;

namespace ListViewSample
{
    [Activity(Label = "ListViewSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {

        ListView assignmentsListView;

        LinearLayout assignmentActiveLayout;

        TextView number,
            name,
            job,
            phone,
            address,
            timerText;


        ArrayList list_item_number = new ArrayList();
        ArrayList list_assingment_name = new ArrayList();
        ArrayList list_assingment_job = new ArrayList();
        ArrayList list_assingment_phone = new ArrayList();
        ArrayList list_assingment_Address = new ArrayList();

        protected override void OnCreate(Bundle bundle)
        {




            base.OnCreate(bundle);
			//SetContentView(Resource.Layout.Main); 
			//var listView = FindViewById<ListView>(Resource.Id.listView1);
			//var data = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
			//listView.Adapter = new ArrayAdapter(this, Resource.Layout.ListViewTemplate1, data);

			SetContentView(Resource.Layout.MainLayoutTest); 
			assignmentsListView = FindViewById<ListView> (Resource.Id.mainLayoutTestListView);
            //assignmentActiveLayout = FindViewById<LinearLayout> (Resource.Id.assignmentSelectedItem);

		//	var data = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
 
         
     

         //   var view = new View (this);
         /*   LayoutInflater inflator = (LayoutInflater)GetSystemService (Context.LayoutInflaterService);
            view = inflator.Inflate (Resource.Layout.AssignmentItemLayout, null);
            assignmentActiveLayout.AddView (view);
            view.LayoutParameters = new LinearLayout.LayoutParams (LinearLayout.LayoutParams.FillParent, LinearLayout.LayoutParams.WrapContent);
          view.SetBackgroundDrawable (Resources.GetDrawable (Resource.Drawable.active_assignment_selector));
            */


     /*       number = view.FindViewById<TextView>(Resource.Id.assignmentItemNumber);
            job = view.FindViewById<TextView>(Resource.Id.assignmentJob);
            name = view.FindViewById<TextView>(Resource.Id.assignmentName);
            phone = view.FindViewById<TextView>(Resource.Id.assignmentPhone);
            address = view.FindViewById<TextView>(Resource.Id.assignmentAddress);
           //   buttonLayout = view.FindViewById<LinearLayout>(Resource.Id.assignmentButtonLayout);
          //  timerLayout = view.FindViewById<LinearLayout>(Resource.Id.assignmentTimerLayout);
          //  activeSpinner = view.FindViewById<Spinner>(Resource.Id.assignmentStatus);
          //  spinnerImage = view.FindViewById<ImageView>(Resource.Id.assignmentStatusImage);
         //   timer = view.FindViewById<ToggleButton>(Resource.Id.assignmentTimer);
            timerText = view.FindViewById<TextView>(Resource.Id.assignmentTimerText);
            */
            for (int i = 1; i < 110; i++)
            {
                list_item_number.Add(i+1);
             /*   list_assingment_name.Add("assingment_name");
                list_assingment_job.Add("aasignmentJob");
                list_assingment_phone.Add("assingment_phone");
                list_assingment_Address.Add("assingment_Address");*/
            }
           

        /*    number.Text ="1";
            job.Text = string.Format("#{0} {1}\n{2}", "JobNumber", "StartDate","CompanyName");
            name.Text = "ContactName";
            phone.Text = "ContactPhone";
            address.Text = string.Format("{0}\n{1}, {2} {3}", "Address", "City", "State", "Zip");
            */

          //  assignmentActiveLayout.Visibility = ViewStates.Visible;

    //  assignmentsListView.Adapter = new ArrayAdapter (this, Resource.Layout.AssignmentItemLayout, data);   //   this produces cast error

              // assignmentsListView.Adapter = new ArrayAdapter(this, Resource.Layout.AssignmentItemLayout, Resource.Id.assignmentItemNumber, list_item_number);

              //  assignmentNameListView.Adapter = new ArrayAdapter(this, Resource.Layout.AssignmentItemLayout, Resource.Id.assignmentName, list_assingment_name);
              //  assignmentJobListView.Adapter = new ArrayAdapter(this, Resource.Layout.AssignmentItemLayout, Resource.Id.assignmentJob, list_assingment_job);
              //  assignmentPhoneListView.Adapter = new ArrayAdapter(this, Resource.Layout.AssignmentItemLayout, Resource.Id.assignmentPhone, list_assingment_phone);
             //   assignmentAddressListView.Adapter = new ArrayAdapter(this, Resource.Layout.AssignmentItemLayout, Resource.Id.assignmentAddress, list_assingment_Address);
               assignmentsListView.FastScrollEnabled = true;





               var listData = CreateSampleData(120);
               assignmentsListView.Adapter = new AssignmentListAdapter(this, listData);
             //  assignmentsListView.Adapter = new ArrayAdapter(this, Resource.Layout.AssignmentItemLayout, listData);


        }

      







        
        private List<Assignment_Model> CreateSampleData(int range)
        {

            var assignmentsList = new List<Assignment_Model>();

            for (int i = 1; i <= range; i++)
            {


                var assignmentModel = new Assignment_Model
                {
                    Assignment_Number = i.ToString(),
                    Assignment_Name = "assingment_name",
                    Assignment_Job = "aasignmentJob",
                    Assignment_Phone = "assingment_phone",
                    Assignment_Adress = "assingment_Address"
                    // Assignment_TimerText 
                };

                assignmentsList.Add(assignmentModel);
            }

            return assignmentsList;
        
        }
        

    }
}

