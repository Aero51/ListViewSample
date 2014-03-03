using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace ListViewSample
{
	class AssignmentListAdapter : BaseAdapter<Assignment_Model>//,AdapterView.IOnItemSelectedListener
    {

        List<Assignment_Model> list_assignment_model;
        Activity context;
        readonly int resourceId;
		View pogled;
        public AssignmentListAdapter(Activity context, List<Assignment_Model> list_assignment_model)
            : base()
        {
            this.context = context;
            this.list_assignment_model = list_assignment_model;
        }
        

        public override Assignment_Model this[int position]
        {
            get { return list_assignment_model[position]; }
        }

        public override int Count
        {
            get { return list_assignment_model.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var assignment = list_assignment_model[position];
            View view = convertView;
			pogled = view;
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.AssignmentItemLayout, null);
            }

            TextView name;
            name = view.FindViewById<TextView>(Resource.Id.assignmentName);
            name.Text = assignment.Assignment_Name;
			Spinner spinner = view.FindViewById<Spinner>(Resource.Id.assignmentStatus);

            var number = view.FindViewById<TextView>(Resource.Id.assignmentItemNumber).Text=assignment.Assignment_Number;
            var job = view.FindViewById<TextView> (Resource.Id.assignmentJob).Text=assignment.Assignment_Job;
         //  var  name = view.FindViewById<TextView>(Resource.Id.assignmentName).Text = assignment.Assignment_Name;
            var phone = view.FindViewById<TextView>(Resource.Id.assignmentPhone).Text = assignment.Assignment_Phone;
            var address = view.FindViewById<TextView>(Resource.Id.assignmentAddress).Text = assignment.Assignment_Adress;
			var buttonLayout = view.FindViewById<RelativeLayout> (Resource.Id.assignmentButtonLayout);
			var timerLayout = view.FindViewById<RelativeLayout> (Resource.Id.assignmentTimerLayout);
			//var timerlinearLayout = view.FindViewById<LinearLayout> (Resource.Id.timerLinearLayout);
			//var spinner = view.FindViewById<Spinner> (Resource.Id.assignmentStatus);
			var spinnerLayout = view.FindViewById<RelativeLayout> (Resource.Id.spinnerLayout);
			var spinnerImage = view.FindViewById<ImageView> (Resource.Id.assignmentStatusImage);
            var accept = view.FindViewById<Button> (Resource.Id.assignmentAccept);
            var decline = view.FindViewById<Button> (Resource.Id.assignmentDecline);
            var phoneIcon = view.FindViewById<ImageView>(Resource.Id.assignmentPhoneIcon);
            var mapIcon = view.FindViewById<ImageView>(Resource.Id.assignmentMapIcon);



           // buttonLayout.Visibility = ViewStates.Visible;
			//  ----   timerLayout.Visibility = ViewStates.Visible;
          //  var items = new List<string>() {"one", "two", "three"};
           // var adapter = new SpinnerAdapter<AssignmentStatus>(assignmentViewModel.AvailableStatuses, Context, Resource.Layout.SimpleSpinnerItem);
           




          //  accept.SetOnClickListener(OnClick(this));
            accept.Click += (sender, e) =>
            {
                accept.Text = " pressed";
				//  buttonLayout.Activated = false;
				buttonLayout.Visibility = ViewStates.Gone;
				spinnerLayout.Visibility= ViewStates.Visible;
                name.Text = "test";
            };

           decline.Click += (sender, e) =>
            {
                decline.Text = "pressed";
            };
            

            return view;
        
        }

     
        public Assignment_Model GetItemAtPosition(int position)
        {
            return list_assignment_model[position];
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.assignmentAccept:
                    {
                        
                    }
                    break;
                case Resource.Id.assignmentDecline:
                    {
                       
                    }
                    break;
				//-----  case Resource.Id.assignmentPhoneLayout:
                    {
                        
                    }
				// ---  break;
				// ---- case Resource.Id.assignmentAddressLayout:
                    {
                       
                    }
				// ----    break;
                default:
                    break;
            }
        }
		public View dajView()
		{
			return pogled;
		}


		public void OnItemSelected (AdapterView parent, View view, int position, long id)
		{
	
		}


    }
}