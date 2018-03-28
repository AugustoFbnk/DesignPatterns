using Patterns.Structural.Decorator;
using Patterns.Behavioral.Iterator;
using Patterns.Structural;
using Patterns.Structural.Proxy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Behavioral.Command;
using Patterns.Creational.AbstractFactory.Abstract;
using Patterns.Creational.AbstractFactory.Concrete;
using Patterns.Creational.AbstractFactory;
using Patterns.Structural.Adapter.Adapters;
using Patterns.Structural.Adapter.Interfaces;
using Patterns.Structural.Adapter;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Decorator

            //var decorator = new CallDecorator();
            //decorator.Call();

            #endregion

            #region Proxy

            //var proxy = new CallProxy();
            //proxy.Call();

            #endregion

            #region Iterator

            //var iterator = new CallIterator();
            //iterator.Call();

            #endregion

            #region Command

            //var command = new CallCommand();
            //command.Call();

            #endregion

            #region Abstract Factory
            
            //var concreteFactoryA = new ConcreteFactoryFile1();
            //var abstractFactory = new CallAbstractFactory();
            //abstractFactory.Call(concreteFactoryA);

            #endregion

            #region Adapter

            //var adapter = new CallAdapter();
            //adapter.Call();

            #endregion
        }
    }
}
