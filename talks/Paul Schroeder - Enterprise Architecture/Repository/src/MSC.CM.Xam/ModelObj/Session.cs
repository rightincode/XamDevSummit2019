// <auto-generated> - Template:MvvmLightModelObject, Version:1.1, Id:c644a31c-7ebc-4383-bc7f-0ea7c5bf6ed4
using GalaSoft.MvvmLight;

namespace MSC.CM.Xam.ModelObj.CM
{
	public partial class Session : ObservableObject
	{
		public Session()
		{
			Feedbacks = new System.Collections.Generic.List<Feedback>(); // Reverse Navigation
			SessionLikes = new System.Collections.Generic.List<SessionLike>(); // Reverse Navigation
			SessionSessionCategoryTypes = new System.Collections.Generic.List<SessionSessionCategoryType>(); // Reverse Navigation
			SessionSpeakers = new System.Collections.Generic.List<SessionSpeaker>(); // Reverse Navigation

			InitializePartial();
		}

		private string _createdBy;
		private System.DateTime _createdUtcDate;
		private int _dataVersion;
		private string _description;
		private System.DateTime? _endTime;
		private bool _isDeleted;
		private string _modifiedBy;
		private System.DateTime _modifiedUtcDate;
		private int? _roomId;
		private int _sessionId;
		private string _shortTitle;
		private System.DateTime? _startTime;
		private string _title;


		public string CreatedBy
		{
			get { return _createdBy; }
			set
			{
				Set<string>(() => CreatedBy, ref _createdBy, value);
				RunCustomLogicSetCreatedBy(value);
			}
		}

		public System.DateTime CreatedUtcDate
		{
			get { return _createdUtcDate; }
			set
			{
				Set<System.DateTime>(() => CreatedUtcDate, ref _createdUtcDate, value);
				RunCustomLogicSetCreatedUtcDate(value);
			}
		}

		public int DataVersion
		{
			get { return _dataVersion; }
			set
			{
				Set<int>(() => DataVersion, ref _dataVersion, value);
				RunCustomLogicSetDataVersion(value);
			}
		}

		public string Description
		{
			get { return _description; }
			set
			{
				Set<string>(() => Description, ref _description, value);
				RunCustomLogicSetDescription(value);
			}
		}

		public System.DateTime? EndTime
		{
			get { return _endTime; }
			set
			{
				Set<System.DateTime?>(() => EndTime, ref _endTime, value);
				RunCustomLogicSetEndTime(value);
			}
		}

		public bool IsDeleted
		{
			get { return _isDeleted; }
			set
			{
				Set<bool>(() => IsDeleted, ref _isDeleted, value);
				RunCustomLogicSetIsDeleted(value);
			}
		}

		public string ModifiedBy
		{
			get { return _modifiedBy; }
			set
			{
				Set<string>(() => ModifiedBy, ref _modifiedBy, value);
				RunCustomLogicSetModifiedBy(value);
			}
		}

		public System.DateTime ModifiedUtcDate
		{
			get { return _modifiedUtcDate; }
			set
			{
				Set<System.DateTime>(() => ModifiedUtcDate, ref _modifiedUtcDate, value);
				RunCustomLogicSetModifiedUtcDate(value);
			}
		}

		public int? RoomId
		{
			get { return _roomId; }
			set
			{
				Set<int?>(() => RoomId, ref _roomId, value);
				RunCustomLogicSetRoomId(value);
			}
		}

		public int SessionId
		{
			get { return _sessionId; }
			set
			{
				Set<int>(() => SessionId, ref _sessionId, value);
				RunCustomLogicSetSessionId(value);
			}
		}

		public string ShortTitle
		{
			get { return _shortTitle; }
			set
			{
				Set<string>(() => ShortTitle, ref _shortTitle, value);
				RunCustomLogicSetShortTitle(value);
			}
		}

		public System.DateTime? StartTime
		{
			get { return _startTime; }
			set
			{
				Set<System.DateTime?>(() => StartTime, ref _startTime, value);
				RunCustomLogicSetStartTime(value);
			}
		}

		public string Title
		{
			get { return _title; }
			set
			{
				Set<string>(() => Title, ref _title, value);
				RunCustomLogicSetTitle(value);
			}
		}

		public virtual System.Collections.Generic.IList<Feedback> Feedbacks { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.IList<SessionLike> SessionLikes { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.IList<SessionSessionCategoryType> SessionSessionCategoryTypes { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.IList<SessionSpeaker> SessionSpeakers { get; set; } // Many to many mapping
		public virtual Room Room { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetCreatedBy(string value);
		partial void RunCustomLogicSetCreatedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetDataVersion(int value);
		partial void RunCustomLogicSetDescription(string value);
		partial void RunCustomLogicSetEndTime(System.DateTime? value);
		partial void RunCustomLogicSetIsDeleted(bool value);
		partial void RunCustomLogicSetModifiedBy(string value);
		partial void RunCustomLogicSetModifiedUtcDate(System.DateTime value);
		partial void RunCustomLogicSetRoomId(int? value);
		partial void RunCustomLogicSetSessionId(int value);
		partial void RunCustomLogicSetShortTitle(string value);
		partial void RunCustomLogicSetStartTime(System.DateTime? value);
		partial void RunCustomLogicSetTitle(string value);

		#endregion RunCustomLogicSet

	}
}