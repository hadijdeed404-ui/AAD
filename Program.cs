using System;
using System.Drawing;
using System.Windows.Forms;
namespace MyProject
{
	public struct stFontStyle
	{
		public string Name;
		public float Size;
		public FontStyle Style;
		public stFontStyle(string Name, float Size, FontStyle Style)
		{
			this.Name = Name;
			this.Size = Size;
			this.Style = Style;
		}
	}
	public struct stFlatAppearanceStyle
	{
		public int BorderSize;
		public Color BorderColor;
		public Color MouseOverBackColor;
		public Color MouseDownBackColor;

		public stFlatAppearanceStyle(int BorderSize, Color BorderColor, Color MouseOverBackColor,
									 Color MouseDownBackColor)
		{
			this.BorderSize = BorderSize;
			this.BorderColor = BorderColor;
			this.MouseOverBackColor = MouseOverBackColor;
			this.MouseDownBackColor = MouseDownBackColor;
		}
	}
	public struct stButtonStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
		public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public stFlatAppearanceStyle FlatSettings;
		public AnchorStyles Anchor;
		public stButtonStyle(string Text, Point Location, Size Size, Color BackgroundColor,
							 Color ForeColor, stFontStyle FontSettings,
							 stFlatAppearanceStyle FlatSettings, AnchorStyles Anchor)
		{
			this.Text = Text;
			this.Size = Size;
			this.Location = Location;
			this.BackgroundColor = BackgroundColor;
			this.ForeColor = ForeColor;
			this.FontSettings = FontSettings;
			this.FlatSettings = FlatSettings;
			this.Anchor = Anchor;
		}
	}
	public struct stTextBoxStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
		public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stTextBoxStyle(string Text, Point Location, Size Size, Color BackgroundColor,
							  Color ForeColor, stFontStyle FontSettings, AnchorStyles Anchor)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.BackgroundColor = BackgroundColor;
			this.ForeColor = ForeColor;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
		}
	}
	public struct stLabelStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
		public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stLabelStyle(string Text, Point Location, Size Size, Color BackgroundColor,
							Color ForeColor, stFontStyle FontSettings, AnchorStyles Anchor)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.BackgroundColor = BackgroundColor;
			this.ForeColor = ForeColor;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
		}
	}
	public struct stCheckBoxStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
		public bool IsChecked;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stCheckBoxStyle(string Text, Point Location, Size Size, bool IsChecked,
							   stFontStyle FontSettings, AnchorStyles Anchor)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.IsChecked = IsChecked;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
		}
	}
	public struct stRadioButtonStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
		public bool IsChecked;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stRadioButtonStyle(string Text, Point Location, Size Size, bool IsChecked,
								  stFontStyle FontSettings, AnchorStyles Anchor)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.IsChecked = IsChecked;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
		}
	}
	public struct stGroupBoxStyle
	{
		public string Text;
		public Point Location;
		public Size Size;
        public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stGroupBoxStyle(string Text, Point Location, Size Size, stFontStyle FontSettings,
							   AnchorStyles Anchor,Color BackgroundColor, Color ForeColor)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
            this.BackgroundColor = BackgroundColor;
            this.ForeColor = ForeColor;
		}
	}
    public struct stMaskedTextBoxStyle
	{
        public string Mask;
        public char PromptChar;
        public MaskFormat TextMaskFormat;
		public string Text;
		public Point Location;
		public Size Size;
		public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
		public stMaskedTextBoxStyle(string Text, Point Location, Size Size, Color BackgroundColor,
	    Color ForeColor, stFontStyle FontSettings, AnchorStyles Anchor,
        string Mask, char PromptChar, MaskFormat TextMaskFormat)
		{
			this.Text = Text;
			this.Location = Location;
			this.Size = Size;
			this.BackgroundColor = BackgroundColor;
			this.ForeColor = ForeColor;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
            this.Mask = Mask;
            this.PromptChar = PromptChar;
            this.TextMaskFormat = TextMaskFormat;
		}
	}
    public struct stComboBoxStyle
	{
		public Point Location;
		public Size Size;
        public Color BackgroundColor;
		public Color ForeColor;
		public stFontStyle FontSettings;
		public AnchorStyles Anchor;
        public ComboBoxStyle DropDownStyle;
		public stComboBoxStyle(Point Location, Size Size, stFontStyle FontSettings,
 	   AnchorStyles Anchor,Color BackgroundColor, Color ForeColor,ComboBoxStyle DropDownStyle)
		{
			this.Location = Location;
			this.Size = Size;
			this.FontSettings = FontSettings;
			this.Anchor = Anchor;
            this.BackgroundColor = BackgroundColor;
            this.ForeColor = ForeColor;
            this.DropDownStyle = DropDownStyle;
		}
	}
    public struct stLinkLabelStyle
    {
        public string Text;
        public Point Location;
        public Size Size;
        public Color BackgroundColor;
        public Color LinkColor;
        public Color VisitedLinkColor;
        public stFontStyle FontSettings;
        public AnchorStyles Anchor;

        public stLinkLabelStyle(string Text, Point Location, Size Size, Color BackgroundColor, Color LinkColor, Color VisitedLinkColor, stFontStyle FontSettings, AnchorStyles Anchor)
        {
            this.Text = Text;
            this.Location = Location;
            this.Size = Size;
            this.BackgroundColor = BackgroundColor;
            this.LinkColor = LinkColor;
            this.VisitedLinkColor = VisitedLinkColor;
            this.FontSettings = FontSettings;
            this.Anchor = Anchor;
        }
    }
    public struct stDateTimePicker
    {
        public Point Location;
        public Size Size;
        public Color BackgroundColor;
        public Color ForeColor;
        public stFontStyle FontSettings;
        public AnchorStyles Anchor;
        
        public DateTimePickerFormat Format;
        public string CustomFormat;
        public bool ShowUpDown;
        public bool ShowCheckBox;
        public DateTime Value;
        public DateTime MinDate;
        public DateTime MaxDate;
        
        public stDateTimePicker(Point Location, Size Size, Color BackgroundColor, Color ForeColor,
        DateTimePickerFormat Format,string CustomFormat,bool ShowUpDown,bool ShowCheckBox,DateTime Value,
        DateTime MinDate,DateTime MaxDate, stFontStyle FontSettings, AnchorStyles Anchor)
        {
            this.Location = Location;
            this.Size = Size;
            this.BackgroundColor = BackgroundColor;
            this.ForeColor = ForeColor;
            this.FontSettings = FontSettings;
            this.Anchor = Anchor;
            this.Format = Format;
            this.CustomFormat = CustomFormat;
            this.ShowUpDown = ShowUpDown;
            this.ShowCheckBox = ShowCheckBox;
            this.Value = Value;
            this.MinDate = MinDate;
            this.MaxDate = MaxDate;
        }
    }
    public struct stProgressBarStyle
    {
        public Point Location;
        public Size Size;
        public int Minimum;
        public int Maximum;
        public int Value;
        public int Step;
        public AnchorStyles Anchor;
        
        public stProgressBarStyle(Point Location, Size Size
        ,AnchorStyles Anchor,int Minimum,int Maximum,int Value,int Step)
        {
            this.Location = Location;
            this.Size = Size;
            this.Anchor = Anchor;
            this.Minimum = Minimum;
            this.Maximum = Maximum;
            this.Value = Value;
            this.Step = Step;
        }
    }
    public struct stMonthCalendar
    {
        public Point Location;
        public Size Size;
        public Color TitleBackColor;
        public Color TitleForeColor;
        public stFontStyle FontSettings;
        public AnchorStyles Anchor;
        public DateTime MinDate;
        public DateTime MaxDate;
        
        public int MaxSelectionCount;
        public DateTime TodayDate;
        public bool ShowToday;
        public bool ShowTodayCircle;
        public bool ShowWeekNumbers;
        
        public stMonthCalendar(Point Location, Size Size, Color TitleBackColor, Color TitleForeColor, stFontStyle FontSettings,
        int MaxSelectionCount,DateTime MinDate,DateTime MaxDate,
        DateTime TodayDate,bool ShowToday=true,bool ShowTodayCircle=true,bool ShowWeekNumbers=false,AnchorStyles Anchor=AnchorStyles.None)
        {
            this.Location = Location;
            this.Size = Size;
            this.TitleBackColor = TitleBackColor;
            this.TitleForeColor = TitleForeColor;
            this.FontSettings = FontSettings;
            this.Anchor = Anchor;
            this.MaxSelectionCount = MaxSelectionCount;
            this.MinDate = MinDate;
            this.MaxDate = MaxDate;
            this.TodayDate = TodayDate;
            this.ShowToday = ShowToday;
            this.ShowTodayCircle = ShowTodayCircle;
            this.ShowWeekNumbers = ShowWeekNumbers;
        }
    }
    public struct stTimer
    {
        public int Interval;
        public bool Enabled;
        public stTimer(int Interval,bool Enabled=false)
        {
            this.Interval = Interval;
            this.Enabled = Enabled;
        }
    }
    public struct stPictureBox
    {
        public string ImagePath;             
        public Point Location;
        public Size Size;
        public Color BackColor; 
        public AnchorStyles Anchor;
        public PictureBoxSizeMode SizeMode;
        public bool Visible;
        public stPictureBox(Point Location, Size Size,PictureBoxSizeMode SizeMode,string ImagePath,bool Visible=true,Color? BackColor=null ,AnchorStyles Anchor=AnchorStyles.None)
        {
            this.ImagePath = ImagePath;
            this.Location = Location;
            this.Size = Size;
            this.Visible = Visible;
            this.SizeMode = SizeMode;
            this.BackColor = BackColor ?? Color.Transparent; 
            this.Anchor = Anchor;
        }
    }
    public struct stNotifyIcon
    {
        public Icon AppIcon;
        public string ToolTipText;
        public string BalloonTitle;
        public string BalloonText;
        public ToolTipIcon BalloonIcon;
        public stNotifyIcon(Icon AppIcon,string ToolTipText,
        string BalloonTitle,string BalloonText,ToolTipIcon BalloonIcon)
        {
            this.AppIcon = AppIcon;
            this.ToolTipText = ToolTipText;
            this.BalloonTitle = BalloonTitle;
            this.BalloonText = BalloonText;
            this.BalloonIcon = BalloonIcon;
        }
    }
    public struct stListViewStyle
    {
       public Point Location;
       public Size Size;
       public Color BackgroundColor;
       public Color ForeColor;
       public stFontStyle FontSettings;
       public AnchorStyles Anchor;
       public View ViewMode;
       public bool FullRowSelect;
       public bool GridLines; 

       public stListViewStyle(Point Location, Size Size, Color BackgroundColor, Color ForeColor, 
       stFontStyle FontSettings, AnchorStyles Anchor, View ViewMode, bool FullRowSelect = true, bool GridLines = true)
       {
           this.Location = Location;
           this.Size = Size;
           this.BackgroundColor = BackgroundColor;
           this.ForeColor = ForeColor;
           this.FontSettings = FontSettings;
           this.Anchor = Anchor;
           this.ViewMode = ViewMode;
           this.FullRowSelect = FullRowSelect;
           this.GridLines = GridLines;
       }
    }
    public struct stTrackBarStyle
    {
       public Point Location;
       public Size Size;
       public Color BackgroundColor;
       public int Minimum;
       public int Maximum;
       public int Value;
       public int TickFrequency;
       public AnchorStyles Anchor;

       public stTrackBarStyle(Point Location, Size Size, Color BackgroundColor, AnchorStyles Anchor,
       int Minimum, int Maximum, int Value, int TickFrequency)
       {
          this.Location = Location;
          this.Size = Size;
          this.BackgroundColor = BackgroundColor;
          this.Anchor = Anchor;
          this.Minimum = Minimum;
          this.Maximum = Maximum;
          this.Value = Value;
          this.TickFrequency = TickFrequency;
       }
    }
    public struct stErrorProviderStyle
    {
       public ErrorBlinkStyle BlinkStyle;

       public stErrorProviderStyle(ErrorBlinkStyle BlinkStyle)
       {
           this.BlinkStyle = BlinkStyle;
       }
    }
    public struct stNumericUpDownStyle
    {
       public Point Location;
       public Size Size;
       public Color BackgroundColor;
       public Color ForeColor;
       public stFontStyle FontSettings;
       public int Minimum;
       public int Maximum;
       public int Value;
       public int Increment;
       public AnchorStyles Anchor;

       public stNumericUpDownStyle(Point Location, Size Size, Color BackgroundColor, 
       Color ForeColor,stFontStyle FontSettings,int Minimum,int Maximum,
       int Value,int Increment, AnchorStyles Anchor)
       {
           this.Location = Location;
           this.Size = Size;
           this.BackgroundColor = BackgroundColor;
           this.ForeColor = ForeColor;
           this.FontSettings = FontSettings;
           this.Minimum = Minimum;
           this.Maximum = Maximum;
           this.Value = Value;
           this.Increment = Increment;
           this.Anchor = Anchor;
       }
    }
    public struct stTabControlStyle
    {
        public Point Location;
        public Size Size;
        public Color BackgroundColor;
        public stFontStyle FontSettings;
        public AnchorStyles Anchor;
        public TabAlignment TabPosition;
        public stTabControlStyle(Point Location, Size Size, Color BackgroundColor, 
        stFontStyle FontSettings,TabAlignment TabPosition,AnchorStyles Anchor)
        {
            this.Location = Location;
            this.Size = Size;
            this.BackgroundColor = BackgroundColor;
            this.FontSettings = FontSettings;
            this.Anchor = Anchor;
            this.TabPosition = TabPosition;
        }
    }
    public struct stPanelStyle
    {
        public Point Location;
        public Size Size;
        public Color BackgroundColor;
        public BorderStyle PanelBorder;
        public AnchorStyles Anchor;
        public DockStyle Dock;

        public stPanelStyle(Point Location, Size Size, Color BackgroundColor, 
        BorderStyle PanelBorder, AnchorStyles Anchor, DockStyle Dock = DockStyle.None)
        {
            this.Location = Location;
            this.Size = Size;
            this.BackgroundColor = BackgroundColor;
            this.PanelBorder = PanelBorder;
            this.Anchor = Anchor;
            this.Dock = Dock;
        }
    }
    public struct stFolderBrowserDialogStyle
    {
        public string Description;
        public bool ShowNewFolderButton;

        public stFolderBrowserDialogStyle(string Description, bool ShowNewFolderButton = true)
        {
            this.Description = Description;
            this.ShowNewFolderButton = ShowNewFolderButton;
        }
    }
    public struct stOpenFileDialogStyle
    {
        public string Filter;
        public string Title;
        public string InitialDirectory;
        public bool Multiselect;

        public stOpenFileDialogStyle(string Filter, string Title, string InitialDirectory, bool Multiselect = false)
        {
            this.Filter = Filter;
            this.Title = Title;
            this.InitialDirectory = InitialDirectory;
            this.Multiselect = Multiselect;
        }
    }
    public struct stSaveFileDialogStyle
    {
        public string Filter;
        public string DefaultExt;
        public string Title;
        public string InitialDirectory;

        public stSaveFileDialogStyle(string Filter, string DefaultExt, string Title, string InitialDirectory)
        {
            this.Filter = Filter;
            this.DefaultExt = DefaultExt;
            this.Title = Title;
            this.InitialDirectory = InitialDirectory;
        }
    }
    public struct stFontDialogStyle
    {
        public bool ShowColor;
        public bool ShowEffects;
        public int MinSize;
        public int MaxSize;

        public stFontDialogStyle(bool ShowColor, bool ShowEffects, int MinSize, int MaxSize)
        {
           this.ShowColor = ShowColor;
           this.ShowEffects = ShowEffects;
           this.MinSize = MinSize;
           this.MaxSize = MaxSize;
        }
    }
    public struct stColorDialogStyle
    {
        public bool FullOpen;
        public bool AnyColor;
        public Color DefaultColor;

        public stColorDialogStyle(bool FullOpen, bool AnyColor, Color DefaultColor)
        {
            this.FullOpen = FullOpen;
            this.AnyColor = AnyColor;
            this.DefaultColor = DefaultColor;
        }
    }
    public struct stContextMenuStripStyle
    {
        public Color BackgroundColor;
        public Color ForeColor;
        public stFontStyle FontSettings;
        public stContextMenuStripStyle(Color BackgroundColor, Color ForeColor, stFontStyle FontSettings)
        {
            this.BackgroundColor = BackgroundColor;
            this.ForeColor = ForeColor;
            this.FontSettings = FontSettings;
        }
    }
    public struct stMenuStripStyle
    {
        public Color BackgroundColor;
        public Color ForeColor;
        public stFontStyle FontSettings;
        public DockStyle Dock;  

        public stMenuStripStyle(Color BackgroundColor, Color ForeColor, stFontStyle FontSettings, DockStyle Dock = DockStyle.Top)
        {
            this.BackgroundColor = BackgroundColor;
            this.ForeColor = ForeColor;
            this.FontSettings = FontSettings;
            this.Dock = Dock;
        }
    }
	public static class clsControlFactory
	{
		public static Button CreateButton(stButtonStyle style)
		{
			Button btn = new Button();
			btn.Text = style.Text;
			btn.Location = style.Location;
			btn.Size = style.Size;
			btn.BackColor = style.BackgroundColor;
			btn.ForeColor = style.ForeColor;
			btn.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			btn.FlatStyle = FlatStyle.Flat;
			btn.FlatAppearance.BorderSize = style.FlatSettings.BorderSize;
			btn.FlatAppearance.BorderColor = style.FlatSettings.BorderColor;
			btn.FlatAppearance.MouseOverBackColor = style.FlatSettings.MouseOverBackColor;
			btn.FlatAppearance.MouseDownBackColor = style.FlatSettings.MouseDownBackColor;
			btn.Anchor = style.Anchor;
			return btn;
		}

		public static TextBox CreateTextBox(stTextBoxStyle style)
		{
			TextBox txt = new TextBox();
			txt.Text = style.Text;
			txt.Location = style.Location;
			txt.Size = style.Size;
			txt.BackColor = style.BackgroundColor;
			txt.ForeColor = style.ForeColor;
			txt.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			txt.Anchor = style.Anchor;
			return txt;
		}

		public static Label CreateLabel(stLabelStyle style)
		{
			Label label = new Label();
			label.Text = style.Text;
			label.Location = style.Location;
			label.Size = style.Size;
			label.BackColor = style.BackgroundColor;
			label.ForeColor = style.ForeColor;
			label.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.Anchor = style.Anchor;
			return label;
		}

		public static CheckBox CreateCheckBox(stCheckBoxStyle style)
		{
			CheckBox chk = new CheckBox();
			chk.Text = style.Text;
			chk.Location = style.Location;
			chk.Size = style.Size;
			chk.Checked = style.IsChecked;
			chk.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			chk.Anchor = style.Anchor;
			return chk;
		}

		public static RadioButton CreateRadioButton(stRadioButtonStyle style)
		{
			RadioButton Rb = new RadioButton();
			Rb.Text = style.Text;
			Rb.Location = style.Location;
			Rb.Size = style.Size;
			Rb.Checked = style.IsChecked;
			Rb.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			Rb.Anchor = style.Anchor;
			return Rb;
		}
		public static GroupBox CreateGroupBox(stGroupBoxStyle style)
		{
			GroupBox grp = new GroupBox();
			grp.Text = style.Text;
			grp.Location = style.Location;
			grp.Size = style.Size;
			grp.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			grp.Anchor = style.Anchor;
            grp.BackColor = style.BackgroundColor;
            grp.ForeColor = style.ForeColor;

			return grp;
		}
        public static MaskedTextBox CreateMaskedTextBox(stMaskedTextBoxStyle style)
		{
			MaskedTextBox mstxt = new MaskedTextBox();
			mstxt.Text = style.Text;
			mstxt.Location = style.Location;
			mstxt.Size = style.Size;
			mstxt.BackColor = style.BackgroundColor;
			mstxt.ForeColor = style.ForeColor;
			mstxt.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			mstxt.Anchor = style.Anchor;
            mstxt.Mask = style.Mask;                
            mstxt.PromptChar = style.PromptChar;     
            mstxt.TextMaskFormat = style.TextMaskFormat;
			return mstxt;
		}
        public static ComboBox CreateComboBox(stComboBoxStyle style)
		{
			ComboBox Cb = new ComboBox();
			Cb.Location = style.Location;
			Cb.Size = style.Size;
			Cb.BackColor = style.BackgroundColor;
			Cb.ForeColor = style.ForeColor;
			Cb.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
			Cb.Anchor = style.Anchor;
            Cb.DropDownStyle = style.DropDownStyle;
			return Cb;
		}
        public static LinkLabel CreateLinkLabel(stLinkLabelStyle style)
        {
          LinkLabel lnk = new LinkLabel();
          lnk.Text = style.Text;
          lnk.Location = style.Location;
          lnk.Size = style.Size;
          lnk.BackColor = style.BackgroundColor;
          lnk.LinkColor = style.LinkColor;
          lnk.VisitedLinkColor = style.VisitedLinkColor;
          lnk.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
          lnk.Anchor = style.Anchor;
    
          return lnk;
        }
        public static DateTimePicker CreateDateTimePicker(stDateTimePicker style)
        {
          DateTimePicker DTP = new DateTimePicker();
          DTP.Location = style.Location;
          DTP.Size = style.Size;
          DTP.BackColor = style.BackgroundColor;
          DTP.ForeColor = style.ForeColor;
          DTP.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
          DTP.Anchor = style.Anchor;
          DTP.ShowUpDown = style.ShowUpDown;
          DTP.ShowCheckBox = style.ShowCheckBox;
          DTP.MinDate = style.MinDate;
          DTP.MaxDate = style.MaxDate;
          DTP.Value = style.Value;
          DTP.Format = style.Format;
          if(!string.IsNullOrEmpty(style.CustomFormat))
          DTP.CustomFormat = style.CustomFormat;
          
          return DTP;
        }
        public static MonthCalendar CreateMonthCalendar(stMonthCalendar style)
        {
          MonthCalendar MC = new MonthCalendar();
          MC.Location = style.Location;
          MC.Size = style.Size;
          MC.TitleForeColor = style.TitleForeColor;
          MC.TitleBackColor = style.TitleBackColor;
          MC.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
          MC.Anchor = style.Anchor;
          MC.MaxSelectionCount = style.MaxSelectionCount;
          MC.MinDate = style.MinDate;
          MC.MaxDate = style.MaxDate;
          MC.TodayDate = style.TodayDate;
          MC.ShowToday = style.ShowToday;
          MC.ShowTodayCircle = style.ShowTodayCircle;
          MC.ShowWeekNumbers = style.ShowWeekNumbers;
          
          return MC;
        }
        public static PictureBox CreatePictureBox(stPictureBox style)
        {
            PictureBox _Pbx = new PictureBox();
            _Pbx.Location = style.Location;
            _Pbx.Size = style.Size;
            _Pbx.SizeMode = style.SizeMode;
            _Pbx.BackColor = style.BackColor; 
            _Pbx.Anchor = style.Anchor;
            _Pbx.Visible = style.Visible;
            if (!string.IsNullOrEmpty(style.ImagePath))
            {
                _Pbx.Image = Image.FromFile(style.ImagePath);
            }
            return _Pbx;
        }
        public static System.Windows.Forms.Timer CreateTimer(stTimer style)
        {
            System.Windows.Forms.Timer T = new System.Windows.Forms.Timer();
            T.Interval = style.Interval;
            T.Enabled = style.Enabled;
            return T;
        }
        public static NotifyIcon CreateNotifyIcon(stNotifyIcon style)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = style.AppIcon;
            notifyIcon.Text = style.ToolTipText;
            notifyIcon.BalloonTipTitle = style.BalloonTitle;
            notifyIcon.BalloonTipText = style.BalloonText;
            notifyIcon.BalloonTipIcon = style.BalloonIcon;
            
            notifyIcon.Visible = true;
            
            return notifyIcon;
        }
        public static ProgressBar CreateProgressBar(stProgressBarStyle style)
        {
            ProgressBar PB = new ProgressBar();
            PB.Location = style.Location;
            PB.Size = style.Size;
            PB.Anchor = style.Anchor;
            PB.Minimum = style.Minimum;
            PB.Maximum = style.Maximum;
            PB.Value = style.Value;
            PB.Step = style.Step;
            PB.Style = ProgressBarStyle.Blocks; 
            return PB;
        }
        public static ListView CreateListView(stListViewStyle style)
        {
            ListView lv = new ListView();
            lv.Location = style.Location;
            lv.Size = style.Size;
            lv.BackColor = style.BackgroundColor;
            lv.ForeColor = style.ForeColor;
            lv.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
            lv.Anchor = style.Anchor;
            lv.View = style.ViewMode;
            lv.FullRowSelect = style.FullRowSelect;
            lv.GridLines = style.GridLines;
    
            return lv;
        }
        public static TrackBar CreateTrackBar(stTrackBarStyle style)
        {
             TrackBar tb = new TrackBar();
             tb.Location = style.Location;
             tb.Size = style.Size;
             tb.BackColor = style.BackgroundColor;
             tb.Anchor = style.Anchor;
             tb.Minimum = style.Minimum;
             tb.Maximum = style.Maximum;
             tb.Value = style.Value;
             tb.TickFrequency = style.TickFrequency;
             tb.TickStyle = TickStyle.BottomRight; 
    
             return tb;
        }
        public static ErrorProvider CreateErrorProvider(stErrorProviderStyle style)
        {
           ErrorProvider ep = new ErrorProvider();
           ep.BlinkStyle = style.BlinkStyle;
           return ep;
        }
        public static NumericUpDown CreateNumericUpDown(stNumericUpDownStyle style)
        {
            NumericUpDown nud = new NumericUpDown();
            nud.Location = style.Location;
            nud.Size = style.Size;
            nud.BackColor = style.BackgroundColor;
            nud.ForeColor = style.ForeColor;
            nud.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
            nud.Anchor = style.Anchor;
            nud.Minimum = style.Minimum;
            nud.Maximum = style.Maximum;
            nud.Value = style.Value;
            nud.Increment = style.Increment;
    
            return nud;
        }
        public static TabControl CreateTabControl(stTabControlStyle style)
        {
            TabControl tc = new TabControl();
            tc.Location = style.Location;
            tc.Size = style.Size;
            tc.BackColor = style.BackgroundColor;
            tc.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
            tc.Anchor = style.Anchor;
            tc.Alignment = style.TabPosition;
            return tc;
        }
        public static Panel CreatePanel(stPanelStyle style)
        {
            Panel pnl = new Panel();
            pnl.Location = style.Location;
            pnl.Size = style.Size;
            pnl.BackColor = style.BackgroundColor;
            pnl.BorderStyle = style.PanelBorder;
            pnl.Anchor = style.Anchor;
            pnl.Dock = style.Dock;
            pnl.AutoScroll = true; 
    
            return pnl;
        }
        public static FolderBrowserDialog CreateFolderBrowserDialog(stFolderBrowserDialogStyle style)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = style.Description;
            fbd.ShowNewFolderButton = style.ShowNewFolderButton;
            return fbd;
        }
        public static OpenFileDialog CreateOpenFileDialog(stOpenFileDialogStyle style)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = style.Filter;
            ofd.Title = style.Title;
            ofd.InitialDirectory = style.InitialDirectory;
            ofd.Multiselect = style.Multiselect;
            ofd.CheckFileExists = true; 
            ofd.CheckPathExists = true;
    
            return ofd;
        }
        public static SaveFileDialog CreateSaveFileDialog(stSaveFileDialogStyle style)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = style.Filter;
            sfd.DefaultExt = style.DefaultExt;
            sfd.Title = style.Title;
            sfd.InitialDirectory = style.InitialDirectory;
            sfd.OverwritePrompt = true; 
    
            return sfd;
        }
        public static FontDialog CreateFontDialog(stFontDialogStyle style)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = style.ShowColor;
            fd.ShowEffects = style.ShowEffects;
            fd.MinSize = style.MinSize;
            fd.MaxSize = style.MaxSize;
            if (style.MinSize > 0 || style.MaxSize > 0)
            {
                fd.AllowVectorFonts = true;
                fd.AllowVerticalFonts = false;
            }
            return fd;
        }
        public static ColorDialog CreateColorDialog(stColorDialogStyle style)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = style.FullOpen;
            cd.AnyColor = style.AnyColor;
            cd.Color = style.DefaultColor;
            return cd;
        }
        public static ContextMenuStrip CreateContextMenuStrip(stContextMenuStripStyle style)
        {
        	ContextMenuStrip cms = new ContextMenuStrip();
        	cms.BackColor = style.BackgroundColor;
        	cms.ForeColor = style.ForeColor;
        	cms.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
        	return cms;
        }
        public static MenuStrip CreateMenuStrip(stMenuStripStyle style)
        {
            MenuStrip ms = new MenuStrip();
            ms.BackColor = style.BackgroundColor;
            ms.ForeColor = style.ForeColor;
            ms.Font = new Font(style.FontSettings.Name, style.FontSettings.Size, style.FontSettings.Style);
            ms.Dock = style.Dock;
            return ms;
        }

	}
	public class MyFirstForm : Form
	{
        private MenuStrip MenuStrip1;
        private ContextMenuStrip ContMenStr1;
        private TextBox TextBox1;
		public MyFirstForm()
		{
            this.Text = "NoteApp";
            this.Size = new Size(1280,720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            
            stFontStyle Font1 = new stFontStyle("Tahoma",14, FontStyle.Bold);
            stTextBoxStyle TxtStyle = new stTextBoxStyle("",new Point(0,0),new Size(0,0),Color.White,Color.Black,Font1,AnchorStyles.None);
            TextBox1 = clsControlFactory.CreateTextBox(TxtStyle);
            TextBox1.Dock = DockStyle.Fill;
            TextBox1.Multiline = true;
            TextBox1.ScrollBars = ScrollBars.Vertical;
            stMenuStripStyle MenuStyle = new stMenuStripStyle(Color.LightGray, Color.Black, Font1, DockStyle.Top);
            MenuStrip1 = clsControlFactory.CreateMenuStrip(MenuStyle);

            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem editMenu = new ToolStripMenuItem("Edit");
            ToolStripMenuItem viewMenu = new ToolStripMenuItem("View");
            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Help");
                        
            ToolStripMenuItem newItem = new ToolStripMenuItem("New");
            ToolStripMenuItem saveItem = new ToolStripMenuItem("Save");
            ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit");
            
            ToolStripMenuItem copyItem = new ToolStripMenuItem("Copy");
            ToolStripMenuItem pasteItem = new ToolStripMenuItem("Paste");
            ToolStripMenuItem selectAllItem = new ToolStripMenuItem("Select All");
            ToolStripMenuItem cutItem = new ToolStripMenuItem("Cut");
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete");

            fileMenu.DropDownItems.Add(newItem);
            fileMenu.DropDownItems.Add(saveItem);
            fileMenu.DropDownItems.Add(new ToolStripSeparator()); 
            fileMenu.DropDownItems.Add(exitItem);
            MenuStrip1.Items.Add(fileMenu);
            
            editMenu.DropDownItems.Add(selectAllItem);
            editMenu.DropDownItems.Add(copyItem);
            editMenu.DropDownItems.Add(pasteItem);
            editMenu.DropDownItems.Add(cutItem);
            editMenu.DropDownItems.Add(new ToolStripSeparator());
            editMenu.DropDownItems.Add(deleteItem);
            
            
            MenuStrip1.Items.Add(editMenu);
            
            MenuStrip1.Items.Add(viewMenu);
            MenuStrip1.Items.Add(helpMenu);
            
            this.Controls.Add(TextBox1);
            this.MainMenuStrip = MenuStrip1;
            this.Controls.Add(MenuStrip1);
            
            
            stContextMenuStripStyle CMSstyle = new stContextMenuStripStyle(Color.LightGray, Color.Black, Font1);
            ContMenStr1 = clsControlFactory.CreateContextMenuStrip(CMSstyle);
            
            ToolStripMenuItem SelectAll = new ToolStripMenuItem("&Select All");
            ToolStripMenuItem DeleteAll = new ToolStripMenuItem("&Delete All");
            ToolStripMenuItem changeColor = new ToolStripMenuItem("Change &Color");
            ToolStripMenuItem changeFont = new ToolStripMenuItem("Change &Font");
            
            changeColor.ShortcutKeys = Keys.Control | Keys.C; 
            changeColor.ShowShortcutKeys = true;
            
            changeFont.ShortcutKeys = Keys.Control | Keys.F;
            changeFont.ShowShortcutKeys = true;
            
            ContMenStr1.Items.Add(SelectAll);
            ContMenStr1.Items.Add(DeleteAll);
            ContMenStr1.Items.Add(changeColor);
            ContMenStr1.Items.Add(changeFont);
            
            changeColor.Click += new EventHandler(changeColor_Clicked);
            changeFont.Click += new EventHandler(changeFont_Clicked);
            
            TextBox1.ContextMenuStrip = ContMenStr1;
            this.WindowState = FormWindowState.Maximized;
        }
        private void changeColor_Clicked(object ? sender,EventArgs e)
        {
            stColorDialogStyle ColorStyle = new stColorDialogStyle(true,true,TextBox1.ForeColor);
            using(ColorDialog CD = clsControlFactory.CreateColorDialog(ColorStyle))
            {
                if(CD.ShowDialog() == DialogResult.OK)
                {
                     TextBox1.ForeColor = CD.Color;
                }
            }
        }
        private void changeFont_Clicked(object ? sender,EventArgs e)
        {
            stFontDialogStyle FontStyle = new stFontDialogStyle(true,true,10,50);
            using(FontDialog FD = clsControlFactory.CreateFontDialog(FontStyle))
            {
                if(FD.ShowDialog() == DialogResult.OK)
                {
                    TextBox1.Font = FD.Font;
                }
            }
        }
    }

    public class Program
	{
		[STAThread] 
        public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MyFirstForm());
        }
    }
}
