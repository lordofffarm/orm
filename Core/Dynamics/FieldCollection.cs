﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenNETCF.ORM
{
    public class FieldCollection : IEnumerable<FieldValue>, ICloneable
    {
        private SafeDictionary<string, FieldValue> m_fields;

        internal FieldCollection()
        {
            m_fields = new SafeDictionary<string, FieldValue>(StringComparer.InvariantCultureIgnoreCase);
        }

        public object Clone()
        {
            var fc = new FieldCollection();
            fc.m_fields.AddRange(this.m_fields.ToDictionary(e => e.Key, e => e.Value.Clone() as FieldValue));
            return fc;
        }

        public int Count
        {
            get { return m_fields.Count; }
        }

        public object this[string fieldName]
        {
            get
            {
                lock (m_fields)
                {
                    if (!m_fields.ContainsKey(fieldName))
                    {
                        return null;
                    }
                    return m_fields[fieldName].Value;
                }
            }
            set 
            {
                lock (m_fields)
                {
                    if (!m_fields.ContainsKey(fieldName))
                    {
                        m_fields.Add(fieldName, new FieldValue(fieldName, value));
                    }
                    else
                    {
                        m_fields[fieldName] = new FieldValue(fieldName, value);
                    }
                }
            }
        }

        public double GetDouble(string fieldName, double nullValue)
        {
            var val = this[fieldName];

            if ((val == null) || (val == DBNull.Value))
            {
                return nullValue;
            }

            return Convert.ToDouble(val);
        }

        public int GetInt32(string fieldName, int nullValue)
        {
            var val = this[fieldName];

            if ((val == null) || (val == DBNull.Value))
            {
                return nullValue;
            }

            return Convert.ToInt32(val);
        }

        public bool ContainsField(string fieldName)
        {
            return m_fields.ContainsKey(fieldName);
        }

        public void Add(string fieldName)
        {
            Add(fieldName, null);
        }

        public void Add(string fieldName, object value)
        {
            lock (m_fields)
            {
                m_fields.Add(fieldName, new FieldValue(fieldName, value));
            }
        }

        public IEnumerator<FieldValue> GetEnumerator()
        {
            return m_fields.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
