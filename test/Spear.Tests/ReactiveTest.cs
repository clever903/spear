using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Spear.Tests
{
    [TestClass]
    public class ReactiveTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //��Ӧʽ���
            var list = Enumerable.Range(1, 100).ToObservable(NewThreadScheduler.Default);
            var subject = new Subject<int>();
            subject.Subscribe((temperature) => Console.WriteLine($"��ǰ�¶ȣ�{temperature}"));//����subject
            subject.Subscribe((temperature) => Console.WriteLine($"��ལ���ǰˮ�£�{temperature}"));//����subject
            list.Subscribe(subject);
            //list.Wait();

            var observable = Observable.Return("shay");
            observable.Subscribe(Console.WriteLine);
        }
    }
}