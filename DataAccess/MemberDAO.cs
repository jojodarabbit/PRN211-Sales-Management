using BusinessObject;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        //Using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        //-------------------------------------------------------------
        public IEnumerable<MemberObject> GetListMembers()
        {
            IDataReader reader = null;
            string SQLSelect = "SELECT MemberId, Email, CompanyName, City, Country, Password FROM Member";
            var members = new List<MemberObject>();
            try
            {
                reader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (reader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberID = reader.GetInt32(0),
                        Email = reader.GetString(1),
                        CompanyName = reader.GetString(2),
                        City = reader.GetString(3),
                        Country = reader.GetString(4),
                        Password = reader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }

            return members;
        }
        public MemberObject GetMemberByID(int memberID)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId, Email, CompanyName, City, Country, Password FROM Member where MemberId = @MemberId";
            MemberObject member = null;
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, memberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }

        public void AddMember(MemberObject member)
        {
            try
            {
                MemberObject memberObject = GetMemberByID(member.MemberID);
                if (memberObject == null)
                {
                    string SQLInsert = "Insert Member Values(@MemberId, @Email, @CompanyName, @City, @Country, @Password)";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@MemberId", 4, member.MemberID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@CompanyName", 50, member.CompanyName, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameter.ToArray());
                }
                else
                {
                    throw new Exception("This member is already exisist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void UpdateMember(MemberObject member)
        {
            try
            {
                MemberObject memberObject = GetMemberByID(member.MemberID);
                if (memberObject != null)
                {
                    string SQLUpdate = "UPDATE Member SET Email = @Email, CompanyName = @CompanyName, City = @City, Country = @Country, Password = @Password where MemberId = @MemberId";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@MemberId", 4, member.MemberID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@CompanyName", 50, member.CompanyName, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameter.ToArray());
                }
                else
                {
                    throw new Exception("This member doesn't exisit.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void RemoveMember(int memberID)
        {
            try
            {
                MemberObject member = GetMemberByID(memberID);
                if (member != null)
                {
                    string SQLDelete = "DELETE Member where MemberId=@MemberId";
                    var param = dataProvider.CreateParameter("@MemberId", 4, memberID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("This member doesn't exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}