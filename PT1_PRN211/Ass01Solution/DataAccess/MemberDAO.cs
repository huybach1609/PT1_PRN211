using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace DataAccess
{
    public class MemberDAO
    {
        private List<MemberObject> ListMember = new List<MemberObject>
        {
            new MemberObject(){ MenberID = 1, MemberName="bach", Email="bach@fstore.com", Password="123", City="Ha Noi", Country="Viet Nam" },
            new MemberObject(){ MenberID = 2, MemberName="long", Email="long@fstore.com", Password="123", City="Can Tho", Country="Viet Nam" },
            new MemberObject(){ MenberID = 3, MemberName="kien", Email="kien@fstore.com", Password="123", City="Ha Noi", Country="Viet Nam" },
            new MemberObject(){ MenberID = 4, MemberName="cuong", Email="cuong@fstore.com", Password="123", City="Thanh Hoa", Country="Viet Nam" },
            new MemberObject(){ MenberID = 5, MemberName="mozart", Email="mozart@fstore.com", Password="456", City="Vienna", Country="Austria" },
            new MemberObject(){ MenberID = 6, MemberName="beethoven", Email="beethoven@fstore.com", Password="789", City="Bonn", Country="Germany" },
            new MemberObject(){ MenberID = 7, MemberName="chopin", Email="chopin@fstore.com", Password="abc", City="Warsaw", Country="Poland" },
            new MemberObject(){ MenberID = 8, MemberName="liszt", Email="liszt@fstore.com", Password="def", City="Budapest", Country="Hungary" }
         };
        private static MemberDAO instance;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<MemberObject> getListMember()
        {
            ListMember.Sort(MemberObject.NameComparison);
            return ListMember;
        }

        public MemberObject GetMemberById(int id)
        {
            MemberObject member = null;
            //var mem = ListMember.Where(x => x.MenberID == id).Select(x => x);
            member = ListMember.SingleOrDefault(x => x.MenberID == id);
            return member;
        }

        // create 
        public void Add(MemberObject member)
        {
            if (GetMemberById(member.MenberID) == null)
            {
                ListMember.Add(member);
            }
            else
            {
                throw new Exception("Add faild: have that id in List ");
            }
        }
        // update 
        public void Update(MemberObject member)
        {
            MemberObject mem = GetMemberById(member.MenberID);
            if (GetMemberById(member.MenberID) != null)
            {
                var index = ListMember.IndexOf(mem);
                ListMember[index] = member;
            }
            else
            {
                throw new Exception("Update faild: does not have that id in List ");
            }
        }
        // delete
        public void Delete(int id)
        {
            MemberObject mem = GetMemberById(id);
            if (mem != null)
            {
                ListMember.Remove(mem);
            }
            else
            {
                throw new Exception("Delete faild: does not have that id in List ");
            }

        }

        internal MemberObject GetMemberByEP(string email, string password)
        {
            MemberObject member = null;
            member = ListMember.SingleOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));
            return member;
        }
    }
}

