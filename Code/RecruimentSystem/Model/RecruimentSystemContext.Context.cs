﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RecruitmentSystemEntities : DbContext
    {
        public RecruitmentSystemEntities()
            : base("name=RecruitmentSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<FeedbackRecruiter> FeedbackRecruiters { get; set; }
        public virtual DbSet<FeedbackStudent> FeedbackStudents { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<InterviewSchedule> InterviewSchedules { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Recommend> Recommends { get; set; }
        public virtual DbSet<Recruiter> Recruiters { get; set; }
        public virtual DbSet<RecruiterAspiration> RecruiterAspirations { get; set; }
        public virtual DbSet<RecruiterReport> RecruiterReports { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Statistical> Statisticals { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StatusInterview> StatusInterviews { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAspiration> StudentAspirations { get; set; }
        public virtual DbSet<StudentReport> StudentReports { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}