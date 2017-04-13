using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void TestConstruct01()
        {
            //arrange
            MyCustomList<int> list = new MyCustomList<int>();

            //act

            //assert
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void TestConstruct02()
        {
            //arrange
            int length = 40;
            MyCustomList<int> list = new MyCustomList<int>(length);
            //act

            //assert
            Assert.AreEqual(40, list.Count);
        }
        [TestMethod]
        public void TestConstruct03()
        {
            //arrange
            MyCustomList<Car> list = new MyCustomList<Car>();

            //act

            //assert
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void TestConstruct04()
        {
            int length = 40;
            MyCustomList<Car> list = new MyCustomList<Car>(length);
            //act

            //assert
            Assert.AreEqual(40, list.Count);
        }
        [TestMethod]
        public void TestConstruct05()
        {
            int length = 9;
            MyCustomList<Car> list = new MyCustomList<Car>(length);
            //act

            //assert
            Assert.AreEqual(16, list.Capacity);
        }
        [TestMethod]
        public void TestConstruct06()
        {
            int length = 8;
            MyCustomList<Car> list = new MyCustomList<Car>(length);
            //act

            //assert
            Assert.AreEqual(8, list.Capacity);
        }
        [TestMethod]
        public void TestConstruct07()
        {
            int length = 1;
            MyCustomList<Car> list = new MyCustomList<Car>(length);
            //act

            //assert
            Assert.AreEqual(4, list.Capacity);
        }
        [TestMethod]
        public void TestConstruct08()
        {
            int length = 4;
            MyCustomList<Car> list = new MyCustomList<Car>(length);
            //act

            //assert
            Assert.AreEqual(4, list.Capacity);
        }
        [TestMethod]
        public void TestConstruct09()
        {
            int length = 20;
            MyCustomList<Car> list = new MyCustomList<Car>(length);
            //act

            //assert
            Assert.AreEqual(32, list.Capacity);
        }
        [TestMethod]
        public void TestConstruct10()
        {
            int length = 1000;
            MyCustomList<Car> list = new MyCustomList<Car>(length);
            //act

            //assert
            Assert.AreEqual(1024, list.Capacity);
        }
        [TestMethod]
        public void TestConstruct11()
        {
            int length = 1000000;
            MyCustomList<Car> list = new MyCustomList<Car>(length);
            //act

            //assert
            Assert.AreEqual(1048576, list.Capacity);
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
        public void TestAdd6()
        {
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> list = new MyCustomList<Car>(2);
            list.myArr[0] = newCar;
            list.myArr[1] = oldCar;
            //act
            list.Add(newCar);

            //assert
            Assert.AreEqual(3, list.Count);
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
        public void TestAddLists1()
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
        public void TestAddLists2()
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
        public void TestAddLists3()
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
        public void TestAddLists4()
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
        public void TestAddLists5()
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
        public void TestAddLists6()
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
        public void TestSubtractLists01()
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
        public void TestSubtractLists02()
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
        public void TestSubtractLists03()
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
        public void TestSubtractLists04()
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
        public void TestSubtractLists05()
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
        public void TestSubtractLists06()
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
        public void TestSubtractLists07()
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
        public void TestSubtractLists08()
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
        public void TestSubtractLists09()
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
        public void TestSubtractLists10()
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
        [TestMethod]
        public void TestIteration2()
        {
            //arrange
            int count = 0;
            MyCustomList<int> numbers;
            numbers = new MyCustomList<int>();
            for(int i = 0; i <1000; i++)
            {
                numbers.Add(i);
            }

            //act
            foreach (int i in numbers)
            {
                count = count + 1;
            }

            //assert
            Assert.AreEqual(1000, count);
        }
        [TestMethod]
        public void TestIteration3()
        {
            //arrange
            int count = 0;
            MyCustomList<int> numbers;
            numbers = new MyCustomList<int>();
            for (int i = 0; i < 10000000; i++)
            {
                numbers.Add(i);
            }

            //act
            foreach (int i in numbers)
            {
                count = count + 1;
            }

            //assert
            Assert.AreEqual(10000000, count);
        }
        [TestMethod]
        public void TestIteration4()
        {
            //arrange
            int count = 0;
            MyCustomList<int> numbers;
            numbers = new MyCustomList<int>();

            //act
            foreach (int i in numbers)
            {
                count = count + 1;
            }

            //assert
            Assert.AreEqual(0, count);
        }
        [TestMethod]
        public void TestSort1()
        {
            //arrange
            int count = 3;
            MyCustomList<int> numbers;
            numbers = new MyCustomList<int>();

            for (int i = 0; i < count; i++)
            {
                numbers.Add(count - i);
            }

            //act
            numbers.SortAsc();

            //assert
            Assert.AreEqual(1, numbers.myArr[0]);
        }
        [TestMethod]
        public void TestSort2()
        {
            //arrange
            int count = 25;
            MyCustomList<int> numbers;
            numbers = new MyCustomList<int>();
            Random number = new Random();

            for (int i = 0; i < count; i++)
            {
                numbers.Add(number.Next(0,100));
            }

            //act
            numbers.SortAsc();

            //assert
            Assert.IsTrue(numbers.myArr[0] < numbers.myArr[count - 1]);
        }
        [TestMethod]
        public void TestSort3()
        {
            //arrange
            MyCustomList<string> letters;
            letters = new MyCustomList<string>();
            letters.Add("e");
            letters.Add("z");
            letters.Add("d");

            //act
            letters.SortAsc();

            //assert
            Assert.AreEqual("d, e, z", letters.ToString());
        }
        [TestMethod]
        public void TestSort4()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> cars = new MyCustomList<Car>();
            cars.Add(newCar);
            cars.Add(oldCar);
            cars.Add(newCar);

            //act
            cars.SortAsc();

            //assert
            Assert.AreEqual(cars.myArr[1], cars.myArr[2]);
        }
        [TestMethod]
        public void TestSort5()
        {
            //arrange
            Car newCar = new Car(2017, "red", 124.5);
            Car oldCar = new Car(1970, "black", 100.3);
            MyCustomList<Car> cars = new MyCustomList<Car>();
            cars.Add(newCar);
            cars.Add(oldCar);
            cars.Add(newCar);

            //act
            cars.SortAsc();

            //assert
            Assert.IsTrue(cars.myArr[0].year < cars.myArr[2].year);
        }

    }
}
