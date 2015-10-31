namespace RusWizards
{
    using System;

    class MobileDevices
    {
        static void Main()
        {
            Factory factory = new Factory();
        }
    }


    public class Factory
    {
        private Pipeline pipeline;

        public Pipeline Pipeline
        {
            get
            {
                return pipeline;
            }
        }

        public Factory()
        {
            // Передал конвееру ссылку на фабрику
            pipeline = new Pipeline(this);
        }
    }


    public class Pipeline
    {
        private Factory factory;

        public Factory Factory
        {
            get
            {
                return factory;
            }
        }

        public Pipeline(Factory factory)
        {
            this.factory = factory;
        }

        public Device CreateSmartphone(Battery battery, Screen screen, OperatingSystem operatingSystem)
        {
            Device device = new Smartphone();

            device.TypeBattery = battery;
            device.TypeScreen = screen;
            device.TypeOperationSystem = operatingSystem;

            return device;
        }

        public Device CreateTablet(Battery battery, Screen screen, OperatingSystem operatingSystem)
        {
            Device tablet = new Tablet();

            tablet.TypeBattery = battery;
            tablet.TypeScreen = screen;
            tablet.TypeOperationSystem = operatingSystem;

            return tablet;
        }
    }


    public abstract class Device
    {
        private Screen typeScreen;
        private Battery typeBattery;
        private OperatingSystem operationSystem;

        public Screen TypeScreen
        {
            get
            {
                return typeScreen;
            }
            set
            {
                typeScreen = value;
            }
        }

        public Battery TypeBattery
        {
            get
            {
                return typeBattery;
            }
            set
            {
                typeBattery = value;
            }
        }

        public OperatingSystem TypeOperationSystem
        {
            get
            {
                return operationSystem;
            }
            set
            {
                operationSystem = value;
            }
        }

        protected Device() { }

        public virtual void GetInfo(ref String screen, ref String battery, ref String system)
        {
            screen = typeScreen.ToString();
            battery = typeBattery.ToString();
            system = operationSystem.ToString();
        }
    }


    public class Smartphone : Device
    {
        public Smartphone() { }

        public void GetInfo() { }
    }


    public class Tablet : Device
    {
        public Tablet() { }

        public void GetInfo() { }
    }


    public enum Screen
    {
        TOUCH_CAPACITIVE,
        TOUCH_RESISTIVE
    }

    public enum Battery
    {
        MAH_1500,
        MAH_2000,
        MAH_3900,
        MAH_4000,
        MAH_4500
    }

    public enum OperatingSystem
    {
        ANDROID,
        WINDOWS_PHONE,
        SYMBIAN
    }

}