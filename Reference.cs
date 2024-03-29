﻿using Sigma_Group_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma_Group_project
{
    public class Reference
    {
        public static List<Project> GetRange(List<Project> item_list, Project item, int range)
        {
            List<Project> other_projects = Sorting.Selected_sort(item_list, Math.Min(item_list.Count, range), item);
            if (other_projects.Contains(item))
            {
                other_projects.Remove(item);
            }
            return other_projects;
        }
    }
}