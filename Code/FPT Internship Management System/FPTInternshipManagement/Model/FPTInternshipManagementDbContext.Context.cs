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
    
    public partial class FptInternshipManagermentEntities : DbContext
    {
        public FptInternshipManagermentEntities()
            : base("name=FptInternshipManagermentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<FeedbackType> FeedbackTypes { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<InterviewSchedule> InterviewSchedules { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<RecruiterAspiration> RecruiterAspirations { get; set; }
        public virtual DbSet<Recruiter> Recruiters { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SkillDepartment> SkillDepartments { get; set; }
        public virtual DbSet<SkillExperience> SkillExperiences { get; set; }
        public virtual DbSet<SkillJob> SkillJobs { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillStudentAspiration> SkillStudentAspirations { get; set; }
        public virtual DbSet<Statistical> Statisticals { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAspiration> StudentAspirations { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}