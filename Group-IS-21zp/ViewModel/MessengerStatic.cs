﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_IS_21zp.ViewModel
{
    public static class MessengerStatic
    {

        public static event Action<object> ActivatedStudentEditMode;

        public static void NotifyStudentEditing(object data)
        {
            ActivatedStudentEditMode?.Invoke(data);
        }

        public static event Action<object> ActivatedTeacherEditMode;

        public static void NotifyTeacherEditing(object data)
        {
            ActivatedTeacherEditMode?.Invoke(data);
        }


        public static event Action<object> ActivatedSubjectEditMode;

        public static void NotifySubjectEditing(object data)
        {
            ActivatedSubjectEditMode?.Invoke(data);
        }
    }
}