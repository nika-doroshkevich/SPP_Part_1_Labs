﻿using System.Collections.Generic;
using System.Security.Cryptography;


namespace FakerDemonstration.DTO
{
    public class Foo
    {
        // test variable for the additional task. Should become = 101
        public int CCC;



        public List<int> Array11;


        public string sdf;
        public int AAA = 123;
        public object ewr = new AesManaged();


        // init in constructor 
        public int a, b;

        // init Faker
        public string TestStr = "It's const str";
        public string Str { set; get; }
        public A A;
        public Boo Boo;

        public Foo(int a)
        {
            this.a = a;
        }

        public Foo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }


        public Foo()
        {

        }

    }
}
