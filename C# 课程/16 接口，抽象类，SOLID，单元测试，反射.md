# 接口与抽象类
* 接口和抽象类都是“软件工程的产物”    
* 具体类-->抽象类-->接口：越来越抽象，内部实现的东西越来越少  
* 抽象类是未完全实现逻辑的类（可以有字段和非public成员，他们代表了“具体逻辑”）  
* 抽象类为复用而生：专门作为基类来使用，也具有解耦功能  
* 封装确定的，开放不确定的，推迟到合适的子类中去实现  
* 接口是完全未实现逻辑的“类”（“纯虚类”，只有函数成员，成员全部public）  
* 接口为解耦而生：“高内聚，低耦合”，方便单元测试  
* 接口是一个“协约”，早已为工业生产所熟知（有分工必有协作，有协作必有协约）  
* 他们都不能实例化，只能用来声明变量，引用具体类（concrete class）的实例  

# 抽象类，接口 引入  

### 抽象类的引入  
为做基类而生的“抽象类”与“开放/关闭”原则  
```csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){    
        }
    }
    abstract class Student//抽象类
    {
        //抽象方法，没有被实现的函数成员一定要是public，abstract，没有{}逻辑体
        abstract public void Study();
    }
}
```

```csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){    
            
        }
    }
    class vehicle//违背了开闭原则，我们对于更改类是关闭的
    {
        public void Stop()
        {
            Console.WriteLine("stopped");
        }
        public void Run(string type)
        {
            if (type == "car")
            {
                Console.WriteLine("car is running...");
            }
            else if(type == "Truck")
            {
                Console.WriteLine("Truck is running...");
            }
        }
    }
    class car:vehicle
    {
        public void Run()
        {
            Console.WriteLine("car is running...");
        }
    }
    class Truck:vehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }

}
```
### 符合开闭原则，方法重写
```csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){    
            
        }
    }
    class Vehicle
    {
        public void Stop()
        {
            Console.WriteLine("stopped");
        }
        public virtual void Run()
        {
            Console.WriteLine("car is running...");
        }
    }
    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("car is running...");
        }
    }
    class Truck:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }

}
```
### 如上方法，实际上vehicle调用run是没有意义的
```csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){    
        }
    }
    abstract class Vehicle
    {
        public void Stop()
        {
            Console.WriteLine("stopped");
        }
        public abstract void Run();
    }
    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("car is running...");
        }
    }
    class Truck:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }
}
```
### 纯抽象类--其实就是接口
```csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){    
        }
    }
    abstract class VehicleBase//可以全部是抽象的
    {
        public abstract void Stop();
        public abstract void Run();
    }
    abstract class Vehicle: VehicleBase
    {
        public override void Stop()
        {
            Console.WriteLine("stopped");
        }
    }
    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("car is running...");
        }
    }
    class Truck:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }
}
```

```Csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){    
        }
    }
    interface IVehicleBase//接口一般I开头 
    {
        void Stop();
        void Run();
    }
    abstract class Vehicle: IVehicleBase
    {
        public  void Stop()
        {
            Console.WriteLine("stopped");
        }

        abstract public void Run();
    }
    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("car is running...");
        }
    }
    class Truck:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }

}
```

# 接口

* 接口与单元测试  
  * 接口的产生：自底向上（重构），自顶向下（设计） 
  * C#接口的实现（隐式，显式，多接口）  
  * 语言对面向对象设计的内建支持：依赖反转，接口隔离，开/闭原则  
  
```csharp
namespace ConsoleApp2{
    class Program{
        static void Main(string[] args){
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };
            Sum(nums1);
            Sum(nums2);//实现了不同类型的函数
        }
        static int Sum(IEnumerable nums){
            int sum = 0;
            foreach (var n in nums) sum += (int)n;
            return sum;
        }
    }
}
```

### 依赖与耦合  
###### 紧耦合
```csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){
            var engine = new Engine();
            var car = new Car(engine);
            car.Run(3);
            Console.WriteLine(car.Speed);
        }
    }

    //紧耦合,Engine出了问题，car没法工作
    class Engine
    {
        public int PRM { get; private set; }
        public void Work(int gas)
        {
            this.PRM = 1000 * gas;
        }
    }
    class Car
    {
        private Engine _engine;
        public Car(Engine engine)
        {
            _engine = engine;
        }
        public int Speed { get; private set; }
        public void Run(int gas)
        {
            _engine.Work(gas);
            this.Speed = _engine.PRM / 100;
        }
    }
}
```
###### 降低耦合度--接口  
```csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){
            PhoneUser phoneUser = new PhoneUser(new NokiaPhone());
            phoneUser.UsePhone();
        }
    }

    class PhoneUser
    {
        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }
        public void UsePhone()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.Send();
            _phone.Receive();
        }
    }

    interface IPhone
    {
        void Dail();
        void PickUp();
        void Send();
        void Receive();

    }
    class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("NokiaPhone call...");
        }

        public void PickUp()
        {
            Console.WriteLine("NokiaPhone PickUp...");
        }

        public void Receive()
        {
            Console.WriteLine("NokiaPhone Receive...");
        }

        public void Send()
        {
            Console.WriteLine("NokiaPhone Send...");
        }
    }
    class ErissencPhone : IPhone
    {
        void IPhone.Dail()
        {
            Console.WriteLine("ErissencPhone call...");
        }

        void IPhone.PickUp()
        {
            Console.WriteLine("ErissencPhone PickUp...");
        }

        void IPhone.Receive()
        {
            Console.WriteLine("ErissencPhone Receive...");
        }

        void IPhone.Send()
        {
            Console.WriteLine("ErissencPhone Send...");
        }
    }
}
```

# 依赖反转 测试 
![avatar](https://lh3.googleusercontent.com/4qTxcUCAjpPJ_rDkJMm9ZMnR0HjzD7pnblSoJO9zT3EDDJMC2PDhBpRSo_U1a-nz6aWu_JZL98a14mVdoMjmQBiNBeU8AnB0ehAfngCAKFDAO7ZVP-fQ6mhWrSWJTX5EObOgPSKWf-b477b4P1b9QCI4_zS4ePHOuq5oPJ-R1UFrzonMRZI7Xi-mFgsxQsXHz3W7Duju0zcDZOCIOrXhE10tNPKMUjnbCGR7ThvXUKsigxXtlZbOGnJaR1E9Z_lA4XOtnI49F9Tl3i6FZ8z3FIaXIs7ov1rHrAFFj1mDaC45fQEDiWkQtP__L570l1Aw3vBJHKacGwSDdy0L1sMObIaWaQo2kgTTLh8kOrwDU4_LlyAdzuNEXeaRvsVSEhTm7HtKRR9SCBFdjp82ePjNwhxL580CA1Q715QT2B4sdgjsMITDh_JUGJ4UxAAa2a7pzrVbLbWZm_uRhgglItOpKv9mjZ9y9UDlYND0sU-s9r7uxf2BwXPfoY-FQy8aCPmGflvO19RlILaO6hUdFqgOzHssf6secbiqXlB-JyvKHBmElhgxu4VJm-VdtH9kyz87IuRlBn6KkSiqhxVHGxQZOxUAiKmQ5-rS2MQWtgwbysgySvEWN7RKTF7V72BoNgXrA8uMVW-hHilOCaUHXUDWmgynuTfOzLJp=w865-h625-no)    

### 紧耦合
每次需要修改class PowerSupply  
```
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){
            var fan = new DeskFan(new PowerSupply);
            fan.Work();
        }
    }

    class PowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }

    class DeskFan
    {
        private PowerSupply _powerSupply;
        public DeskFan(PowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power <= 0)
            {
                return "won't work";
            }
            else if (power < 100)
            {
                return "slow";
            }
            else
            {
                return "work fine";
            }
        }
    }
}
```

# 测试
###  主函数  
```csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){
            var fan = new DeskFan(new PowerSupply());
            fan.Work();
        }
    }
    public interface IPowerSupply
    {
        int GetPower();
    }
    public class PowerSupply: IPowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }

    public  class DeskFan
    {
        private IPowerSupply _powerSupply;
        public DeskFan(IPowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power <= 0)
            {
                return "won't work";
            }
            else if (power <= 100)
            {
                return "slow";
            }
            else
            {
                return "work fine";
            }
        }
    }
}
```
### 测试  
add->item-->ConsoleApp2.Tests  
add-->dependencies  
```csharp
namespace ConsoleApp2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PowerLowerThan0_OK()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 0);
            var fan = new DeskFan(mock.Object);
            var expected = "won't work";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerLowerThan100_warning()
        {
            //用mock可以省略下面的class
            var fan = new DeskFan(new PoerSupplyLowerThan100());
            var expected = "slow";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }
    }
    class PoerSupplyLowerThan100 : IPowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }
    class PoerSupplyLowerThanZero : IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }
}
```


# 接口  
###  违反隔离原则一，笼统的在一起  
```csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){
            var driver = new Driver(new Car());
            driver.Drive();//Car is running...
            //如果需要即开车又要开坦克？
        }
    }
    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void Drive()
        {
            _vehicle.Run();
        }
    }
    interface IVehicle
    {
        void Run();
    }
    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }
    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }
    interface ITank
    {
        void Fire();
        void Run();
    }
    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom");
        }

        public void Run()
        {
            Console.WriteLine("LightTank running");
        }
    }
    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!!");
        }

        public void Run()
        {
            Console.WriteLine("MediumTank running");
        }
    }
}
```
升级  
```csharp
namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){
            var driver = new Driver(new Car());
            driver.Drive();//Car is running...
            var driver1 = new Driver(new LightTank());
            driver1.Drive();//LightTank running
        }
    }
    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void Drive()
        {
            _vehicle.Run();
        }
    }
    interface IVehicle
    {
        void Run();
    }
    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }
    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }

    interface IWeapon
    {
        void Fire();
    }
    interface ITank:IWeapon,IVehicle
    {
    }
    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom");
        }

        public void Run()
        {
            Console.WriteLine("LightTank running");
        }
    }
    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!!");
        }

        public void Run()
        {
            Console.WriteLine("MediumTank running");
        }
    }
}
```

###  违反隔离原则二，过犹不及  
