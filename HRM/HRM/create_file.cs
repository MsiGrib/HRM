using HRM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Spire.Doc;
using Spire.Doc.Documents;

namespace HRM
{
    public class create_file
    {
        private static FileInfo file_info;

        public static void worker_info(string path, string text, worker worker, string icon, DateTime date, bool is_date)
        {
            personal_cabinet_worker(path, worker.Name, text, icon);
            document_job("../../../template_add_worker.docx", worker, path, date, is_date);
            word_to_pdf(path, worker.Name);
        }

        private static void personal_cabinet_worker(string path, string name, string text, string icon)
        {
            Directory.CreateDirectory(path + $"/Личный кабинет работника {name}");
            File.WriteAllText(path + $"/Личный кабинет работника {name}/Опыт работы в других компаниях.txt", encryption.Encrypt(text));
            File.Copy(icon, Path.Combine(path + $"/Личный кабинет работника {name}/icon_{name}.png"));
        }
        private static void word_to_pdf(string path, string name)
        {
            Document document = new Document();
            document.LoadFromFile($"{path}\\Личный кабинет работника {name}\\Заявление на работу {name}.doc");
            document.SaveToFile($"{path}\\Личный кабинет работника {name}\\Заявление на работу {name}.pdf", FileFormat.PDF);
        }

        private static void document_job(string file_name, worker worker, string path, DateTime date, bool is_date)
        {
            try
            {
                if (File.Exists(file_name))
                    file_info = new FileInfo(file_name);
                else
                    MessageBox.Show(language_pack.get_cf_failed_creat(), language_pack.get_error());
                Dictionary<string, string> items = new Dictionary<string, string>
            {
                { "<ORG>", $"ООО ExIspo {Environment.NewLine} Частная комерческая компания {Environment.NewLine} OutSorce бизнес"},
                { "<FIO>", worker.Name},
                { "<SKILL>", worker.Grade},
                { "<OTDEL>", worker.Department.ToString()},
                { "<DATA_TIME>", is_date == true ? date.ToString() : "                  " },
                { "<SELARY>", worker.Salary.ToString()}
            };

                Word.Application app = new Word.Application();
                Object file = file_info.FullName;
                Object missing = Type.Missing;
                app.Documents.Open(file);

                foreach (var i in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = i.Key;
                    find.Replacement.Text = i.Value;
                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;
                    find.Execute
                    (
                        FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing,
                        Replace: replace
                    );
                }
                Object new_file_name = Path.Combine($"{path}\\Личный кабинет работника {worker.Name}", $"Заявление на работу {worker.Name}.doc");
                app.ActiveDocument.SaveAs2(new_file_name);
                app.ActiveDocument.Close();
                app.Quit();
            } catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, language_pack.get_error());
            }
        }
    }
}
