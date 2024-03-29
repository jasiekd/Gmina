﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmina.Body
{

    public partial class ElectionsBody : UserControl
    {

        public ElectionsBody()
        {
            InitializeComponent();
        }

        private void ElectionsBody_Load(object sender, EventArgs e)
        {
            List<wiersz> wiersze = new List<wiersz>();
            wiersze.Add(new wiersz() {ID=1,Name= "Wybory na burmistrza", EndDate = "10.01.2023" });  
            wiersze.Add(new wiersz() {ID=2,Name= "Wybory na aa", EndDate = "10.01.2023" });  
            wiersze.Add(new wiersz() {ID=3,Name="tak", EndDate = "10.01.2023" });  
            CandidatesList.Rows.Clear();
            CandidatesList.Rows.Add(wiersze[0].ID, wiersze[0].Name, wiersze[0].EndDate);
            CandidatesList.Rows.Add(wiersze[1].ID, wiersze[1].Name, wiersze[0].EndDate);
            CandidatesList.Rows.Add(wiersze[2].ID, wiersze[2].Name, wiersze[0].EndDate);
        }

        private void CandidatesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CandidatesList.Columns[e.ColumnIndex].Name == "chooseElection")
            {
                ElectionPage electionPage = new ElectionPage();
                

                electionPage.ShowDialog();

                // pobierz wiersz, w którym znajduje się przycisk
                DataGridViewRow row = CandidatesList.Rows[e.RowIndex];
                
                // wyłącz przycisk
                row.Cells[2].Value="wylaczony";
                   
            }
        }

        private void CitizenVotesButton_Click(object sender, EventArgs e)
        {
            CandidatesList.Rows.Clear();
            //To do: ładowanie listy głosowań obywatelskich z bazy (bazując na tym jak to działa w funkcji ElectionsBody_Load )


        }

        private void OfficialVoteButton_Click(object sender, EventArgs e)
        {
            CandidatesList.Rows.Clear();
            //To do: ładowanie listy głosowań urzędowych z bazy (bazując na tym jak to działa w funkcji ElectionsBody_Load )
        }
    }
    public class wiersz
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string EndDate { get; set; }
    }
   
}
