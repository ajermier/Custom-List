using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    public class Car
    {
        public int year; public string color; public double topSpeed;
        public Car(int year, string color, double topSpeed)
        {
            this.year = year;
            this.color = color;
            this.topSpeed = topSpeed;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstruct1()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();

            //act

            //assert
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void TestConstruct2()
        {
            //arrange
            int length = 40;
            MyCustomList<int> list = new MyCustomList<int>(length);
            //act

            //assert
            Assert.AreEqual(40, list.Count);
        }
        [TestMethod]
        public void TestConstruct3()
        {
            //arrange
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act

            //assert
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void TestConstruct4()
        {
            int length = 40;
            MyCustomList<Car> list = new MyCustomList<Car>(length);
            //act

            //assert
            Assert.AreEqual(40, list.Count);
        }

        [TestMethod]
        public void TestAdd1()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();

            //act
            list.Add(3);

            //assert
            Assert.AreEqual(3, list.myArr[0]);
        }
        [TestMethod]
        public void TestAdd2()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();

            //act
            list.Add(3);

            //assert
            Assert.IsNotNull(list.myArr[0]);
        }
        [TestMethod]
        public void TestAdd3()
        {
            //arrange
            MyCustomList<string> list = new MyCustomList<string>();

            //act
            list.Add("hello");

            //assert
            Assert.AreEqual("hello", list.myArr[0]);
        }
        [TestMethod]
        public void TestAdd4()
        {
            //arrange
            MyCustomList<string> list = new MyCustomList<string>();

            //act
            list.Add("hello");

            //assert
            Assert.AreEqual(1, list.Count);
        }
        [TestMethod]
        public void TestAdd5()
        {
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();
            //act
            list.Add(newCar);
            list.Add(oldCar);

            //assert
            Assert.AreEqual(2, list.Count);
        }
        [TestMethod]
        public void TestCount1()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();

            //act

            //assert
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void TestCount2()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();
            //act
            list.Add(newCar);
            list.Add(oldCar);

            //assert
            Assert.AreEqual(2, list.Count);
        }
        [TestMethod]
        public void TestCount3()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();
            //act
            list.Add(newCar);
            list.Add(oldCar);
            list.RemoveAll(newCar);

            //assert
            Assert.AreEqual(1, list.Count);
        }
        [TestMethod]
        public void TestCount4()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();
            list.Add(newCar);
            list.Add(oldCar);
            list.RemoveAll(oldCar);
            list.RemoveAll(newCar);
            //act

            //assert
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void TestCount5()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            //act

            //assert
            Assert.AreEqual(5, list.Count);
        }
        [TestMethod]
        public void TestRemove1()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();
            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //assert
            Assert.IsTrue(list.Remove(3));
        }
        [TestMethod]
        public void TestRemove2()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();
            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);


            //assert
            Assert.IsFalse(list.Remove(11));
        }
        [TestMethod]
        public void TestRemove3()
        {
            //arrange
            MyCustomList<string> list = new MyCustomList<string>();

            //act
            list.Add("hello");
            list.Add("world");
            list.Add("hello");

            //assert
            Assert.IsTrue(list.Remove("hello"));
        }
        [TestMethod]
        public void TestRemove4()
        {
            //arrange
            MyCustomList<string> list = new MyCustomList<string>();

            //act
            list.Add("hello");
            list.Add("world");
            list.Add("hello");
            list.Remove("hello");

            //assert
            Assert.AreEqual(2, list.Count);
        }
        [TestMethod]
        public void TestRemove5()
        {
            //arrange
            MyCustomList<string> list = new MyCustomList<string>();

            //act
            list.Remove("hello");

            //assert
            Assert.IsFalse(list.Remove("hello"));
        }
        [TestMethod]
        public void TestRemove6()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act
            list.Add(newCar);
            list.Add(oldCar);

            //assert
            Assert.IsTrue(list.Remove(newCar));
        }
        [TestMethod]
        public void TestRemove7()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act
            list.Add(newCar);
            list.Add(oldCar);
            list.Remove(newCar);

            //assert
            Assert.IsTrue(list.Remove(oldCar));
        }
        [TestMethod]
        public void TestRemove8()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act
            list.Remove(oldCar);
            list.Remove(newCar);

            //assert
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void TestRemoveAll1()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();
            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //assert
            Assert.IsTrue(list.RemoveAll(3));
        }
        [TestMethod]
        public void TestRemoveAll2()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();
            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);


            //assert
            Assert.IsFalse(list.RemoveAll(11));
        }
        [TestMethod]
        public void TestRemoveAll3()
        {
            //arrange
            MyCustomList<string> list = new MyCustomList<string>();

            //act
            list.Add("hello");
            list.Add("world");
            list.Add("hello");

            //assert
            Assert.IsTrue(list.RemoveAll("hello"));
        }
        [TestMethod]
        public void TestRemoveAll4()
        {
            //arrange
            MyCustomList<string> list = new MyCustomList<string>();

            //act
            list.Add("hello");
            list.Add("world");
            list.Add("hello");
            list.RemoveAll("hello");

            //assert
            Assert.AreEqual(1, list.Count);
        }
        [TestMethod]
        public void TestRemoveAll5()
        {
            //arrange
            MyCustomList<string> list = new MyCustomList<string>();

            //act
            list.RemoveAll("hello");

            //assert
            Assert.IsFalse(list.RemoveAll("hello"));
        }
        [TestMethod]
        public void TestRemoveAll6()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act
            list.Add(newCar);
            list.Add(oldCar);

            //assert
            Assert.IsTrue(list.RemoveAll(newCar));
        }
        [TestMethod]
        public void TestRemoveAll7()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act
            list.Add(newCar);
            list.Add(oldCar);
            list.RemoveAll(newCar);

            //assert
            Assert.IsTrue(list.RemoveAll(oldCar));
        }
        [TestMethod]
        public void TestRemoveAll8()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act
            list.RemoveAll(oldCar);
            list.RemoveAll(newCar);

            //assert
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void TestToString1()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();

            //act
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //assert
            Assert.AreEqual("1, 2, 3", list.ToString());
        }
        [TestMethod]
        public void TestToString2()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act
            list.Add(newCar);
            list.Add(oldCar);

            //assert
            Assert.AreEqual("Car, Car", list.ToString());
        }
        [TestMethod]
        public void TestToString3()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act
            list.Add(newCar);
            list.Add(null);

            //assert
            Assert.AreEqual("Car,  ", list.ToString());
        }
        [TestMethod]
        public void TestToString4()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act
            list.Add(newCar);
            list.Add(null);
            list.Add(oldCar);

            //assert
            Assert.AreEqual("Car,  , Car", list.ToString());
        }
        [TestMethod]
        public void TestToString5()
        {
            //arrange
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act

            //assert
            Assert.AreEqual("EMPTY LIST", list.ToString());
        }
        [TestMethod]
        public void AddLists1()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);

            list3 = list1 + list2;

            //assert
            Assert.AreEqual("1, 2, 3, 4, 5, 6", list3.ToString());
        }
        [TestMethod]
        public void AddLists2()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            list3= list1 + list2;

            //assert
            Assert.AreEqual("1, 2, 3", list3.ToString());
        }
        [TestMethod]
        public void AddLists3()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);

            list3 = list1 + list2;

            //assert
            Assert.AreEqual(6, list3.Count);
        }
        [TestMethod]
        public void AddLists4()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            list3 = list1 + list2;

            //assert
            Assert.AreEqual(3, list3.Count);
        }
        [TestMethod]
        public void AddLists5()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            list3 = list1 + list2;

            //assert
            Assert.ReferenceEquals(list3, list1);
        }
        [TestMethod]
        public void AddLists6()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list1 = new MyCustomList<Car>();
            MyCustomList<Car> list2 = new MyCustomList<Car>();
            MyCustomList<Car> list3 = new MyCustomList<Car>();

            //act
            list1.Add(newCar);
            list1.Add(oldCar);
            list1.Add(newCar);
            list2.Add(oldCar);
            list2.Add(oldCar);
            list2.Add(newCar);

            list3 = list1 + list2;

            //assert
            Assert.AreEqual(6, list3.Count);
        }
        [TestMethod]
        public void SubtractLists1()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);

            list3 = list1 - list2;

            //assert
            Assert.AreEqual("EMPTY LIST", list3.ToString());
        }
        [TestMethod]
        public void SubtractLists2()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            list3 = list1 - list2;

            //assert
            Assert.AreEqual("1, 2, 3", list3.ToString());
        }
        [TestMethod]
        public void SubtractLists3()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);

            list3 = list1 - list2;

            //assert
            Assert.AreEqual(0, list3.Count);
        }
        [TestMethod]
        public void SubtractLists4()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            list3 = list1 - list2;

            //assert
            Assert.AreEqual(3, list3.Count);
        }
        [TestMethod]
        public void SubtractLists5()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            list3 = list1 - list2;

            //assert
            Assert.AreEqual(list1, list3);
        }
        [TestMethod]
        public void SubtractLists6()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(1);

            list3 = list1 - list2;

            //assert
            Assert.AreEqual("2, 3", list3.ToString());
        }
        [TestMethod]
        public void SubtractLists7()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(2);
            list2.Add(3);

            list3 = list1 - list2;

            //assert
            Assert.AreEqual("1", list3.ToString());
        }
        [TestMethod]
        public void SubtractLists8()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list1 = new MyCustomList<Car>();
            MyCustomList<Car> list2 = new MyCustomList<Car>();
            MyCustomList<Car> list3 = new MyCustomList<Car>();

            //act
            list1.Add(newCar);
            list1.Add(oldCar);
            list1.Add(oldCar);
            list2.Add(newCar);
            list2.Add(newCar);

            list3 = list1 - list2;

            //assert
            Assert.AreEqual("Car, Car", list3.ToString());
        }
        [TestMethod]
        public void SubtractLists9()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list1 = new MyCustomList<Car>();
            MyCustomList<Car> list2 = new MyCustomList<Car>();
            MyCustomList<Car> list3 = new MyCustomList<Car>();

            //act
            list1.Add(oldCar);
            list1.Add(oldCar);
            list1.Add(oldCar);
            list2.Add(oldCar);

            list3 = list1 - list2;

            //assert
            Assert.AreEqual("EMPTY LIST", list3.ToString());
        }
        [TestMethod]
        public void SubtractLists10()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list1 = new MyCustomList<Car>();
            MyCustomList<Car> list2 = new MyCustomList<Car>();
            MyCustomList<Car> list3 = new MyCustomList<Car>();

            //act
            list1.Add(newCar);
            list1.Add(oldCar);
            list1.Add(oldCar);
            list1.Add(newCar);
            list1.Add(newCar);
            list2.Add(newCar);
            list2.Add(newCar);

            list3 = list1 - list2;

            //assert
            Assert.AreEqual(2, list3.Count);
        }
        [TestMethod]
        public void TestZipLists1()
        {
            //arrange
            MyCustomList<string> list1 = new MyCustomList<string>();
            MyCustomList<string> list2 = new MyCustomList<string>();
            MyCustomList<string> list3 = new MyCustomList<string>();

            //act
            list1.Add("hello");
            list1.Add("hello");
            list1.Add("hello");
            list2.Add("world");
            list2.Add("world");
            list2.Add("world");

            list3 = list3.ZipLists(list1, list2);

            //assert
            Assert.AreEqual(6, list3.Count);
        }
        [TestMethod]
        public void TestZipLists2()
        {
            //arrange
            MyCustomList<string> list1 = new MyCustomList<string>();
            MyCustomList<string> list2 = new MyCustomList<string>();
            MyCustomList<string> list3 = new MyCustomList<string>();

            //act
            list1.Add("hello");
            list1.Add("hello");
            list1.Add("hello");
            list2.Add("world");
            list2.Add("world");
            list2.Add("world");

            list3 = list3.ZipLists(list1, list2);

            //assert
            Assert.AreEqual("hello, world, hello, world, hello, world", list3.ToString());
        }
        [TestMethod]
        public void TestZipLists3()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            list3 = list3.ZipLists(list1, list2);

            //assert
            Assert.AreEqual("1, 2, 3, 4, 5, 6", list3.ToString());
        }
        [TestMethod]
        public void TestZipLists4()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);

            list3 = list3.ZipLists(list1, list2);

            //assert
            Assert.AreEqual("1, 2, 3, 5", list3.ToString());
        }
        [TestMethod]
        public void TestZipLists5()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);

            list3 = list3.ZipLists(list1, list2);

            //assert
            Assert.AreEqual(4, list3.Count);
        }
        [TestMethod]
        public void TestZipLists6()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);

            list3 = list3.ZipLists(list1, list2);

            //assert
            Assert.AreEqual(list3.ToString(), list1.ToString());
        }
        [TestMethod]
        public void TestZipLists7()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>();
            MyCustomList<int> list2 = new MyCustomList<int>();
            MyCustomList<int> list3 = new MyCustomList<int>();

            //act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);

            list3 = list3.ZipLists(list1, list2);

            //assert
            Assert.AreEqual(3, list3.Count);
        }
        [TestMethod]
        public void TestIteration1()
        {
            //arrange
            string result = "";
            MyCustomList<int> numbers;
            numbers = new MyCustomList<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            //act

            foreach (int i in numbers)
            {
                result = result + $"{i} ";
            }

            //assert
            Assert.AreEqual("1 2 3 ", result);
        }
    }
}
