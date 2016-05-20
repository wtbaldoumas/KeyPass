using KeyPassInfoObjects;
using System.Collections.Generic;
using System.IO;

namespace KeyPassBusiness
{
    public static class ControlLinker
    {
        private static bool _isModified = false;
        private static bool _updateInfo = false;
        private static Group _selectedGroup = null;
        private static Group _previousGroup = null;
        private static Key _selectedKey = null;
        private static Key _previousKey = null;
        private static List<string> _auditFlow = new List<string>();
        private static bool _updateSuccess = false;
        private static int _auditCount = 0;

        public static bool IsModified
        {
            get { return _isModified; }
            set { _isModified = value; }
        }
        
        public static Group SelectedGroup
        {
            get { return _selectedGroup; }
            set { _selectedGroup = value; }
        }

        public static Group PreviousGroup
        {
            get { return _previousGroup; }
            set { _previousGroup = value; }
        }

        public static Key SelectedKey
        {
            get { return _selectedKey; }
            set { _selectedKey = value; }
        }

        public static Key PreviousKey
        {
            get { return _previousKey; }
            set { _previousKey = value; }
        }

        public static bool UpdateKeyInfo
        {
            get { return _updateInfo; }
            set { _updateInfo = value; }
        }

        public static bool UpdateSuccess
        {
            get { return _updateSuccess; }
            set { _updateSuccess = value; }
        }

        public static void AddAuditFlow(string auditEntry)
        {
            _auditFlow.Add(auditEntry);
        }

        public static void ClearAuditFlow()
        {
            _auditFlow.Clear();
        }

        public static string GetAuditFlow(int index)
        {
            return _auditFlow[index];
        }

        public static int AuditCount
        {
            get { return _auditCount; }
            set { _auditCount = value; }
        }

        public static void OnNewClick()
        {
            _isModified = false;
            _updateInfo = false;
            _selectedGroup = null;
            _previousGroup = null;
            _selectedKey = null;
            _previousKey = null;
            _auditFlow.Clear();
            _auditFlow.Add(": New document opened");
            _updateSuccess = true;
            _auditCount = 1;
        }

        public static void OnOpenClick()
        {
            _isModified = false;
            _updateInfo = false;
            _selectedGroup = null;
            _previousGroup = null;
            _selectedKey = null;
            _previousKey = null;
            _auditFlow.Clear();
            _auditFlow.Add(": File " + Path.GetFileName(KeyPassManager.FileName) + " opened");
            _updateSuccess = true;
            _auditCount = 1;
        }

        public static void OnSaveClick()
        {
            _isModified = false;
            _auditFlow.Clear();
            _auditFlow.Add(": File " + Path.GetFileName(KeyPassManager.FileName) + " saved");
            _updateSuccess = true;
            _auditCount = 1;
        }
    }
}
