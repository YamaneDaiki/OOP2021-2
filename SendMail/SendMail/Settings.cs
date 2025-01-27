﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail {
    //設定情報
    public class Settings {
        private static Settings instance = null;

        public int Port { get; set; }   //ポート番号
        public string Host { get; set; }   //ホスト名
        public string MailAddr { get; set; } //メールアドレス
        public string Pass { get; set; }    //パスワード
        public bool Ssl { get; set; }   //SSL

        //コンストラクタ
        private Settings() { }

        //インスタンスの取得
        public static Settings getInstance() {
            if (instance == null) {
                instance = new Settings();
                }
            return instance;
            }


        //初期値
        public string sHost() {
            return "smtp.gmail.com";
            }

        public string sPort() {
            return 587.ToString();
            }

        public string sMailAddr() {
            return "ojsinfosys01@gmail.com";
            }

        public string sPass() {
            return "Infosys2021";
            }

        public bool sSsl() {
            return true;
            }
        }
    }
