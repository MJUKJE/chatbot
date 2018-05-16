﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace my_first_chatbot.Helper.StoredStringValues
{
    [Serializable]
    public class StoredStringValuesMaster
    {

        // 기본 메뉴    welcome options
        public string _courseRegistration = "수강 신청";
        public string _courseInformation = "과목 정보";
        public string _credits = "학점 관리";
        public string _others = "기타 정보";
        public List<string> _welcomeOptionsList = new List<string>();

        // 수강 신청 선택시 메뉴     course registration options
        public string _howToDoIt = "수강신청 방법";             //웹 연결
        public string _schedule = "수강신청 일정";              //웹 연결
        public string _regulation = "수강신청 규정";            //웹 연결
        public string _terms = "수강신청 용어";                 //우리가 정의? 혹은 웹 연결?
        public List<string> _courseRegistrationOptions = new List<string>();

        // 과목 정보 선택시 메뉴     course info options
        public string _openedCourses = "이번학기 개설과목";   //myiweb에 있는데 우짜지..
        public string _syllabus = "강의계획서";                //이것도..
        public string _lecturerInfo = "강사 정보";             //이것도..
        public string _mandatorySubject = "필수과목 정보";      //이건 어떻게 가능
        public string _prerequisite = "선수과목 정보";          //이것도 탐색
        public List<string> _courseInfoOptions = new List<string>();

        // 학점 관리 선택시 메뉴     credit options
        public string _currentCredits = "나의 이수학점";        //개인별 정보 필요
        public string _majorCredits = "전공 학점";
        public string _electiveCredits = "선택 학점";
        public List<string> _creditsOptions = new List<string>();

        // 기타 정보 선택시 메뉴     others options
        public string _leaveOrRejoin = "휴학 및 복학";         //웹 연결
        public string _scholarship = "장학금 관련";            //웹 연결
        public List<string> _othersOption = new List<string>();

        // 도움말 선택시 메뉴       help options
        public string _introduction = "AAR안내";
        public string _requestInformationCorrection = "정보수정요청";
        public string _contactMaster = "관리자 연결";
        public List<string> _helpOptionsList = new List<string>();

        // 처음으로 혹은 도움말      goto start and help
        public string _gotostart = "처음으로";
        public string _help = "도움말";


        public StoredStringValuesMaster()
        {
            _welcomeOptionsList = new List<string> { _courseRegistration, _courseInformation, _credits, _others, _help };
            _courseRegistrationOptions = new List<string> { _howToDoIt, _schedule, _regulation, _terms, _gotostart, _help };
            _courseInfoOptions = new List<string> { _openedCourses, _syllabus, _lecturerInfo, _mandatorySubject, _prerequisite, _gotostart, _help };
            _creditsOptions = new List<string> { _currentCredits, _majorCredits, _electiveCredits, _gotostart, _help };
            _othersOption = new List<string> { _leaveOrRejoin, _scholarship, _gotostart, _help };
            _helpOptionsList = new List<string> { _introduction, _requestInformationCorrection, _contactMaster, _gotostart };

        }
    }
}