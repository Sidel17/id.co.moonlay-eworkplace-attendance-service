using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Text;

namespace EWorkplaceAbsensiService.Lib.Models.Employee
{
    public class EmployeeProfile : StandardEntity
    {
        public EmployeeProfile()
        {

        }

        public EmployeeProfile(
            string firstname,
            string lastname,
            string employeeIdentity,
            DateTimeOffset dateOfBirth,
            Gender gender,
            int religionId,
            string phoneNumber,
            string personalEmail,
            int roleId,
            int divisionId,
            EmploymentStatus status,
            DateTimeOffset joinDate,
            string corporateEmail,
            string skillSet,
            double salary,
            double tax,
            string healthInsuranceNumber,
            string employmentInsuranceNumber,
            string taxParticipantNumber,
            string bankAccountName,
            string bankName,
            string bankAccountNumber,
            string bankBranch
            )
        {

            Firstname = firstname;
            Lastname = lastname;
            EmployeeIdentity = employeeIdentity;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            ReligionId = religionId;
            PhoneNumber = phoneNumber;
            PersonalEmail = personalEmail;
            RoleId = roleId;
            DivisionId = divisionId;
            Status = status;
            JoinDate = joinDate;
            CorporateEmail = corporateEmail;
            SkillSet = skillSet;
            Salary = salary;
            Tax = tax;
            HealthInsuranceNumber = healthInsuranceNumber;
            EmploymentInsuranceNumber = employmentInsuranceNumber;
            TaxParticipantNumber = taxParticipantNumber;
            BankAccountName = bankAccountName;
            BankName = bankName;
            BankAccountNumber = bankAccountNumber;
            BankBranch = bankBranch;
}

        [MaxLength(256)]
        public string Firstname { get; private set; }
        [MaxLength(256)]
        public string Lastname { get; private set; }
        [MaxLength(64)]
        public string EmployeeIdentity { get; private set; }
        public DateTimeOffset DateOfBirth { get; private set; }
        public Gender Gender { get; private set; }
        public int ReligionId { get; private set; }
        [MaxLength(64)]
        public string PhoneNumber { get; private set; }
        [MaxLength(256)]
        public string PersonalEmail { get; private set; }
        public int RoleId { get; private set; }
        public int DivisionId { get; private set; }
        public EmploymentStatus Status { get; private set; }
        public DateTimeOffset JoinDate { get; private set; }
        [MaxLength(256)]
        public string CorporateEmail { get; private set; }
        public string SkillSet { get; private set; }
        public double Salary { get; private set; }
        public double Tax { get; private set; }
        [MaxLength(128)]
        public string HealthInsuranceNumber { get; private set; }
        [MaxLength(128)]
        public string EmploymentInsuranceNumber { get; private set; }
        [MaxLength(128)]
        public string TaxParticipantNumber { get; private set; }
        [MaxLength(512)]
        public string BankAccountName { get; private set; }
        [MaxLength(256)]
        public string BankName { get; private set; }
        [MaxLength(128)]
        public string BankAccountNumber { get; private set; }
        [MaxLength(256)]
        public string BankBranch { get; private set; }
    }
}
