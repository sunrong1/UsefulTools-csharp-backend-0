using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageFeatures;

namespace UnitTestDavaTools
{
    [TestClass]
    public class DelegateTest
    {
        [TestMethod]
        public void TeacherEventTest()
        {
            DelegateEventTeacher MrLi = new DelegateEventTeacher();
            MrLi.PublishInfo();
            //事件的操作，只能使用+= 或者 -=
            MrLi.OnOrderEvent += DelegateXiaoMing.TestInfo;//订阅事件
            MrLi.OnOrderEvent += DelegateJoy.TestInfo;//向Publisher订阅事件，等待被通知
            Assert.IsTrue(MrLi.Issue());//事件触发
        }

        [TestMethod]
        public void TeacherDelegateTest()
        {
            DelegateEventTeacher MrLi = new DelegateEventTeacher();
            MrLi.PublishInfo();
            //委托的操作，能使用+= 或者 -= 和new
            MrLi.DelegateHandle = DelegateJoy.TestInfo;//委托中添加方法
            MrLi.DelegateHandle += DelegateXiaoMing.TestInfo;//添加方法
            MrLi.DelegateHandle += DelegateJoy.TestInfo;
            Assert.IsTrue(MrLi.DelegateIssue());//委托调用
        }
    }
}
