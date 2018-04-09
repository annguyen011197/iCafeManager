using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
    public partial class FormEclipse : Component
    {
        public FormEclipse()
        {
            InitializeComponent();
            InitTimer();
            if (this.TargetControl == null)
            {
                this.TargetControl = this.ContainerControl;
            }
        }

        public FormEclipse(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            InitTimer();

        }

        public void ApplyElipse()
        {
            try
            {
                if (this.control != null)
                {
                    Elipse.Apply(this.control, this.size);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi sủ lý FormEclipse");
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                this.timer.Stop();
                if (this.control != null)
                {
                    this.control.Resize += this.control_Resize;
                }
                else
                {
                    this.control = this.ContainerControl;
                    this.control.Resize += this.control_Resize;
                }
                if (this.control.GetType() == typeof(Form))
                {
                    ((Form)this.control).FormBorderStyle = FormBorderStyle.None;
                }
                this.ApplyElipse();
            }
            catch (Exception)
            {
                this.timer.Start();
            }
        }

        private void control_Resize(object sender, EventArgs e)
        {
            Elipse.Apply(this.control, this.size);
            if (this.eventHandler != null)
            {
                this.eventHandler(sender, e);
            }
        }

        private void InitTimer()
        {
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer.Enabled = true;
            this.timer.Tick += this.timer_Tick;
        }


        private ContainerControl ContainerControl
        {
            get
            {
                return this.containerControl;
            }
            set
            {
                this.containerControl = value;
                this.ApplyElipse();
            }
        }

        public Control TargetControl
        {
            get
            {
                return this.control;
            }
            set
            {
                this.control = value;
            }
        }

        public int ElipseRadius
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
                this.ApplyElipse();
            }
        }

        public override ISite Site
        {
            get
            {
                return base.Site;
            }
            set
            {
                base.Site = value;
                if (value == null)
                {
                    return;
                }
                IDesignerHost designerHost = value.GetService(typeof(IDesignerHost)) as IDesignerHost;
                if (designerHost != null)
                {
                    IComponent rootComponent = designerHost.RootComponent;
                    if (rootComponent is ContainerControl)
                    {
                        this.ContainerControl = (rootComponent as ContainerControl);
                        return;
                    }
                }
            }
        }

        public event EventHandler TargetControlResized
        {
            [CompilerGenerated]
            add
            {
                EventHandler eventHandler = this.eventHandler;
                EventHandler eventHandler2;
                do
                {
                    eventHandler2 = eventHandler;
                    EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                    eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler, value2, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
            [CompilerGenerated]
            remove
            {
                EventHandler eventHandler = this.eventHandler;
                EventHandler eventHandler2;
                do
                {
                    eventHandler2 = eventHandler;
                    EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                    eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler, value2, eventHandler2);
                }
                while (eventHandler != eventHandler2);
            }
        }


        private ContainerControl containerControl;

        [CompilerGenerated]
        private EventHandler eventHandler;

        private int size = 5;

        private Control control;

        private System.Windows.Forms.Timer timer;
    }
}
