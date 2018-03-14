﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project002
{
    public partial class Form1 : Form
    {
        // 생성자~ 가정 먼저 자동 호출된다.
        public Form1()
        {
            // 각 위젯 초기화, 이곳은 건들지 말 것
            InitializeComponent();
            //~~~~~~~~~~~~~이곳에 초기화~~~~~~~~~~~~~~~~~//
            this.Clear(); // 메서드 호출
        }
        // 반복되는 행위를 메서드로 만든다.
        // 텍스트와 라벨 초기화, 메서드 선언
        private void Clear()
        {
            this.txtNum1.Text = "";// 텍스트박스 청소
            this.txtNum2.Text = "";
            this.txtResult.Text = "";
            this.lbResult.Text = "Ready";// 라벨 초기화
        }
        // 숫자 타입 문자열을 숫자로 형변환, 메서드 선언
        private double Calculator(string sx, string sy, string opp)
        {
            if (string.IsNullOrEmpty(sx) || string.IsNullOrEmpty(sy)) {
                MessageBox.Show("공백이 입력되었습니다. 다시 입력하세요.");
            }
            try
            {
                double x = double.Parse(sx.Trim());
                double y = double.Parse(sy.Trim());
                double z = 0.0;// 사칙연산 결과를 저장할 임시 변수

                // 사칙연산이 어떤 것인지 판단
                switch(opp)
                {
                    case "+": z = x + y; break;
                    case "-": z = x - y; break;
                    case "*": z = x * y; break;
                    case "/": z = x / y; break;

                }

                return z;// 사칙연산에 맞는 값을 리턴한다.
            }
            catch
            {
                MessageBox.Show("숫자를 입력하세요. 다시 입력하세요.");
                this.Clear();
                throw new Exception("숫자를 입력하세요. 다시 입력하세요.");
            }
        }
        // btnAdd가 클릭되면 자동 호출된다.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {   // Calculator를 호출할 때 문제가 발생할 수도 있다.
                // Calculator 파라미터에 사칙연산 중 어떤 연산인지 알리는 문자열 포함
                this.txtResult.Text = Calculator(this.txtNum1.Text, this.txtNum2.Text, "+").ToString();
                this.lbResult.Text = "+";// 라벨 초기화
            }
            catch { }
        }
        // btnClear가 클릭되면 자동 호출된다.
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();// 텍스트박스, 라벨 청소와 초기화
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            try
            {   
                this.txtResult.Text = Calculator(this.txtNum1.Text, this.txtNum2.Text, "*").ToString();
                this.lbResult.Text = "*";// 라벨 초기화
            }
            catch { }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResult.Text = Calculator(this.txtNum1.Text, this.txtNum2.Text, "-").ToString();
                this.lbResult.Text = "-";// 라벨 초기화
            }
            catch { }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResult.Text = Calculator(this.txtNum1.Text, this.txtNum2.Text, "/").ToString();
                this.lbResult.Text = "/";// 라벨 초기화
            }
            catch { }
        }
    }
}
