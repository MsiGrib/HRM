using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM
{
    public static class language_pack
    {
        public static bool is_eng = false;
        public static string get_error()
        {
            return is_eng ? "Error" : "Ошибка";
        }
        public static string get_wait()
        {
            return is_eng ? "Wait" : "Ожидайте";
        }
        public static string get_info()
        {
            return is_eng ? "Info" : "Информация";
        }

        #region auth
        public static string get_auth_clear_data()
        {
            return is_eng ? "You have entered empty data" : "Вы ввели пустые данные";
        }
        public static string get_auth_no_rep_pas()
        {
            return is_eng ? "You repeated your password incorrectly" : "Вы неправильно повторили пароль";
        }
        public static string get_auth_register_compl()
        {
            return is_eng ? "Registration completed successfully" : "Регистрация прошла успешно";
        }
        public static string get_auth_no_img()
        {
            return is_eng ? "You haven't added a photo" : "Вы не добавили фотографию";
        }
        public static string get_auth_all_no_filds()
        {
            return is_eng ? "You have not filled in all fields" : "Вы заполнили не все поля";
        }
        public static string get_auth_involid_data()
        {
            return is_eng ? "You entered incorrect data" : "Вы ввели некоректные данные";
        }
        public static string get_auth_add_worker_compl()
        {
            return is_eng ? "Employee added successfully" : "Работник добавлен успешно";
        }
        #endregion


        #region derectory_worker
        public static string get_derectory_worker_crypt()
        {
            return is_eng ? " (crypted.)" : " (зашифр.)";
        }
        #endregion


        #region add_worker
        public static string get_add_worker_select_img()
        {
            return is_eng ? "Select employee photo" : "Выберите фотографию работника";
        }
        #endregion


        #region all_workers
        public static string get_aw_fio()
        {
            return is_eng ? "Name" : "ФИО";
        }
        public static string get_aw_levl()
        {
            return is_eng ? "Level" : "Уровень";
        }
        public static string get_aw_depor()
        {
            return is_eng ? "Department" : "Отдел";
        }
        public static string get_aw_sell()
        {
            return is_eng ? "Salary" : "Зарплата";
        }
        public static string get_aw_ex()
        {
            return is_eng ? "Work Experience" : "Опыт работы";
        }
        public static string get_aw_all_case()
        {
            return is_eng ? "All tasks" : "Все задачи";
        }
        public static string get_aw_compl_case()
        {
            return is_eng ? "Completed tasks" : "Выполненые задачи";
        }
        public static string get_aw_did_hous()
        {
            return is_eng ? "Working hours" : "Часы работы";
        }
        public static string get_aw_kpd()
        {
            return is_eng ? "Efficiency" : "Производительность";
        }
        public static string get_aw_name_user()
        {
            return is_eng ? "Username" : "Имя пользователя";
        }
        public static string get_aw_password()
        {
            return is_eng ? "Password" : "Пароль";
        }
        public static string get_aw_email()
        {
            return is_eng ? "Email" : "Электронная почта";
        }
        public static string get_aw_worker_name()
        {
            return is_eng ? "Employee Name" : "Имя Работника";
        }
        public static string get_aw_docyment_info()
        {
            return is_eng ? "Passport details" : "Паспортные данные";
        }
        public static string get_aw_deport()
        {
            return is_eng ? "Department" : "Отдел";
        }
        public static string get_aw_levle()
        {
            return is_eng ? "Level" : "Уровень";
        }
        public static string get_aw_sellary()
        {
            return is_eng ? "Salary" : "Зарплата";
        }
        public static string get_aw_exp()
        {
            return is_eng ? "Experience" : "Опыт работы";
        }
        public static string get_aw_edu()
        {
            return is_eng ? "Education" : "Образование";
        }
        public static string get_aw_hou()
        {
            return is_eng ? "Hour" : "Часы";
        }
        public static string get_aw_mont()
        {
            return is_eng ? "Month" : "Месяц";
        }
        public static string get_aw_id_work()
        {
            return is_eng ? "Id worker" : "Id работника";
        }
        #endregion


        #region profile_worker
        public static string get_pw_search_worker()
        {
            return is_eng ? "Search an employee" : "Поиск работника";
        }
        public static string get_pw_edit()
        {
            return is_eng ? "Edit" : "Редактировать";
        }
        public static string get_pw_no_data()
        {
            return is_eng ? "No data" : "Нет данных";
        }
        public static string get_pw_no_levl()
        {
            return is_eng ? "Level" : "Уровень";
        }
        public static string get_pw_no_sell()
        {
            return is_eng ? "Salary" : "Зарплата";
        }
        public static string get_pw_no_all_case()
        {
            return is_eng ? "Total tasks" : "Всего заданий";
        }
        public static string get_pw_compl_case()
        {
            return is_eng ? "Completed tasks" : "Выполненые задания";
        }
        public static string get_pw_hours()
        {
            return is_eng ? "Hours" : "Часы";
        }
        public static string get_pw_kpd()
        {
            return is_eng ? "Efficiency" : "Производительность";
        }
        public static string get_pw_decrpt()
        {
            return is_eng ? "Decipher" : "Расшифровать";
        }
        public static string get_pw_encrypt()
        {
            return is_eng ? "Encrypt" : "Зашифровать";
        }

        public static string get_pw_January()
        {
            return is_eng ? "January" : "Январь";
        }
        public static string get_pw_February()
        {
            return is_eng ? "February" : "Февраль";
        }
        public static string get_pw_March()
        {
            return is_eng ? "March" : "Март";
        }
        public static string get_pw_April()
        {
            return is_eng ? "April" : "Апрель";
        }
        public static string get_pw_May()
        {
            return is_eng ? "May" : "Май";
        }
        public static string get_pw_June()
        {
            return is_eng ? "June" : "Июнь";
        }
        public static string get_pw_July()
        {
            return is_eng ? "July" : "Июль";
        }
        public static string get_pw_August()
        {
            return is_eng ? "August" : "Август";
        }
        public static string get_pw_September()
        {
            return is_eng ? "September" : "Сентябрь";
        }
        public static string get_pw_October()
        {
            return is_eng ? "October" : "Октябрь";
        }
        public static string get_pw_November()
        {
            return is_eng ? "November" : "Ноябрь";
        }
        public static string get_pw_December()
        {
            return is_eng ? "December" : "Декабрь";
        }
        #endregion


        #region adress_f
        public static string get_af_clear_data()
        {
            return is_eng ? "You have entered empty data" : "Вы ввели пустые данные";
        }
        public static string get_af_no_worker()
        {
            return is_eng ? "No such user" : "Нет такого пользователя";
        }
        public static string get_af_sign_in()
        {
            return is_eng ? "Sign in" : "Войти в систему";
        }
        public static string get_af_username()
        {
            return is_eng ? "Username" : "Имя пользователя";
        }
        public static string get_af_password()
        {
            return is_eng ? "Password" : "Пароль";
        }
        public static string get_af_log_in()
        {
            return is_eng ? "Log in" : "Войти";
        }
        public static string get_af_register()
        {
            return is_eng ? "Register" : "Зарегистрироваться";
        }
        public static string get_af_recru()
        {
            return is_eng ? "Recruitment" : "Приём на работу";
        }
        public static string get_af_emplo()
        {
            return is_eng ? "Employee records" : "Учёт работников";
        }
        public static string get_af_analy()
        {
            return is_eng ? "Analytics" : "Аналитика";
        }
        #endregion


        #region auth_password
        public static string get_ap_password()
        {
            return is_eng ? "Password" : "Пароль";
        }
        public static string get_ap_confirm()
        {
            return is_eng ? "Confirm" : "Подтвердить";
        }
        public static string get_ap_empty_data()
        {
            return is_eng ? "You have entered empty data" : "Вы ввели пустые данные";
        }
        public static string get_ap_no_user ()
        {
            return is_eng ? "No such user" : "Нет такого пользователя";
        }
        #endregion


        #region main_f
        public static string get_mf_add_worker()
        {
            return is_eng ? "Add an employee" : "Добавить работника";
        }
        public static string get_mf_all_workers()
        {
            return is_eng ? "All employees" : "Все работники";
        }
        public static string get_mf_pers_acc_worker()
        {
            return is_eng ? "Personal account of employees" : "Личный кабинет работников";
        }
        public static string get_mf_analitic()
        {
            return is_eng ? "Analytics" : "Аналитика";
        }
        public static string get_mf_go_out()
        {
            return is_eng ? "Go out" : "Выйти";
        }
        public static string get_mf_settings()
        {
            return is_eng ? "Settings" : "Настройки";
        }
        #endregion


        #region signup_f
        public static string get_sf_registr()
        {
            return is_eng ? "Registration" : "Регистрация";
        }
        public static string get_sf_username()
        {
            return is_eng ? "Username" : "Имя пользователя";
        }
        public static string get_sf_password()
        {
            return is_eng ? "Password" : "Пароль";
        }
        public static string get_sf_repeat_password()
        {
            return is_eng ? "Repeat password" : "Повторите пароль";
        }
        public static string get_sf_email()
        {
            return is_eng ? "Mail" : "Почта";
        }
        public static string get_sf_upload_img()
        {
            return is_eng ? "Upload a photo" : "Загрузить фото";
        }
        public static string get_sf_regist()
        {
            return is_eng ? "Register" : "Зарегистрироваться";
        }
        public static string get_sf_recruit()
        {
            return is_eng ? "Recruitment" : "Приём на работу";
        }
        public static string get_sf_employee()
        {
            return is_eng ? "Employee records" : "Учёт работников";
        }
        public static string get_sf_analitic()
        {
            return is_eng ? "Analytics" : "Аналитика";
        }
        #endregion


        #region create_file
        public static string get_cf_failed_creat()
        {
            return is_eng ? "Failed to create a job application" : "Не получилось создать заявление на работу";
        }
        #endregion


        #region language_pack
        public static string get_lp_darck()
        {
            return is_eng ? "Dark" : "Тёмная";
        }
        public static string get_lp_light()
        {
            return is_eng ? "Light" : "Светлая";
        }
        #endregion

        #region redact_db
        public static string get_rdb_info()
        {
            return is_eng ? "Employee data" : "Данные о работнике";
        }
        public static string get_rdb_fio()
        {
            return is_eng ? "Full name" : "ФИО";
        }
        public static string get_rdb_docymet_info()
        {
            return is_eng ? "Passport details" : "Паспортные данные";
        }
        public static string get_rdb_educ()
        {
            return is_eng ? "Education" : "Образование";
        }
        public static string get_rdb_ex()
        {
            return is_eng ? "Experience" : "Опыт работы";
        }
        public static string get_rdb_all_case()
        {
            return is_eng ? "All case" : "Все задачи";
        }
        public static string get_rdb_compl_case()
        {
            return is_eng ? "Completed case" : "Выполненные задачи";
        }
        public static string get_rdb_house()
        {
            return is_eng ? "Hours" : "Часы";
        }
        public static string get_rdb_dev_level()
        {
            return is_eng ? "Development level" : "Уровень разработки";
        }
        public static string get_rdb_depart()
        {
            return is_eng ? "Department" : "Отдел";
        }
        public static string get_rdb_sel()
        {
            return is_eng ? "Salary" : "Зарплата";
        }
        public static string get_rdb_up_date()
        {
            return is_eng ? "Update date" : "Обновить данные";
        }
        public static string get_rdb_del()
        {
            return is_eng ? "Delete" : "Удалить";
        }
        #endregion
    }
}