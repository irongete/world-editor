using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace World_Editor.Database
{
    public class MySqlConnector
    {
        private string ConnectionStr;
        private MySqlConnection Connection;
        private ICore Core;

        public MySqlConnector(string host, string database, string user, string password, ICore c)
        {
            this.ConnectionStr = "SERVER=" + host + ";DATABASE=" + database + ";UID=" + user + ";PASSWORD=" + password + ";";
            this.Core = c;
            Connection = new MySqlConnection(ConnectionStr);
            Connection.Open();
        }

        public void Connect()
        {
            Connection.Open();
        }

        public void Disconnect()
        {
            Connection.Close();
        }

        public MySqlConnection MySqlConnection
        {
            get
            {
                return MySqlConnection;
            }
        }

        public CreatureTemplate GetCreatureTemplate(uint entry)
        {
            MySqlCommand Command = Connection.CreateCommand();
            Command.CommandText = Core.GetCreatureTemplate(entry);
            MySqlDataReader Reader = Command.ExecuteReader();

            CreatureTemplate ct = null;

            while (Reader.Read())
            {
                object[] row = new object[Reader.FieldCount];
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    row[i] = Reader.GetValue(i);
                }
                ct = Core.CreateCreatureTemplate(row);
                break;
            }

            Reader.Close();
            Command.Dispose();

            return ct;
        }

        /// <summary>
        /// Récupère tous les objets de la base de données.
        /// </summary>
        /// <returns></returns>
        public ItemTemplate[] GetItemTemplate()
        {
            MySqlCommand Command = Connection.CreateCommand();
            Command.CommandText = Core.GetItemTemplate();
            MySqlDataReader Reader = Command.ExecuteReader();

            ArrayList Items = new ArrayList();

            while (Reader.Read())
            {
                object[] row = new object[Reader.FieldCount];
                for (int i = 0; i < Reader.FieldCount; ++i)
                {
                    row[i] = Reader.GetValue(i);
                }
                Items.Add(Core.CreateItemTemplate(row));
            }

            Reader.Close();
            Command.Dispose();

            return (ItemTemplate[])Items.ToArray(typeof(ItemTemplate));
        }

        /// <summary>
        /// Récupère tous les objets de la base de données contenus entre 2 ids.
        /// </summary>
        /// <param name="from">Identifiant de départ</param>
        /// <param name="to">Identifiant de fin</param>
        /// <returns></returns>
        public ItemTemplate[] GetItemTemplate(uint from, uint to)
        {
            MySqlCommand Command = Connection.CreateCommand();
            Command.CommandText = Core.GetItemTemplate(from, to);
            MySqlDataReader Reader = Command.ExecuteReader();

            ArrayList Items = new ArrayList();

            while (Reader.Read())
            {
                object[] row = new object[Reader.FieldCount];
                for (int i = 0; i < Reader.FieldCount; ++i)
                {
                    row[i] = Reader.GetValue(i);
                }
                Items.Add(Core.CreateItemTemplate(row));
            }

            Reader.Close();
            Command.Dispose();

            return (ItemTemplate[])Items.ToArray(typeof(ItemTemplate));
        }

        public List<String> GetItemByName(string name)
        {
            MySqlCommand Command = Connection.CreateCommand();
            Command.CommandText = Core.GetItemByName(name);
            MySqlDataReader Reader = Command.ExecuteReader();

            List<String> Items = new List<string>();
            string itemId = "";
            string itemName;
            while (Reader.Read())
            {
                for (int i = 0; i < Reader.FieldCount; ++i)
                {
                    if (itemId == "")
                    {
                        itemId = Reader.GetValue(i).ToString();
                    }
                    else
                    {
                        itemName = Reader.GetValue(i).ToString();
                        Items.Add(itemId + ", " + itemName);
                        itemId = "";
                    }
                }
            }

            Reader.Close();
            Command.Dispose();

            return Items;
        }

        public List<string> GetItemById(String itemEntry)
        {
            MySqlCommand Command = Connection.CreateCommand();
            Command.CommandText = Core.GetItemById(itemEntry);
            MySqlDataReader Reader = Command.ExecuteReader();

            List<String> Items = new List<string>();
            string itemId = "";
            string itemName;
            while (Reader.Read())
            {
                //Actuellement plutôt laid, modifier la méthode qui récupère les données en base ?
                for (int i = 0; i < Reader.FieldCount; ++i)
                {
                    if (itemId == "")
                    {
                        itemId = Reader.GetValue(i).ToString();
                    }
                    else
                    {
                        itemName = Reader.GetValue(i).ToString();
                        Items.Add(itemId + ", " + itemName);
                        itemId = "";
                    }
                }
            }

            Reader.Close();
            Command.Dispose();

            return Items;
        }
    }
}
