using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


using Laborator6_PostComment;

namespace Laborator6_Client
{
    public partial class Form1 : Form
    {
        List<Post> posts = new List<Post>();
        public Form1()
        {
            InitializeComponent();
        }
        // Handler pentru evenimentul Load al ferestrei principale
        private void Form1_Load(object sender, EventArgs e)
        {
            posts = LoadPosts().ToList<Post>();
            dgp.DataSource = posts;
            dgp.Columns[0].Width = 0;
            if (dgp.Rows.Count > 0)
                dgc.DataSource = posts[0].Comments;
        }
        private static Laborator6_PostComment.Post[] LoadPosts()
        {
            PostCommentClient pc = new PostCommentClient();
            Laborator6_PostComment.Post[] p = pc.GetPosts();
            return p;
        }
        // Handler pentru evenimentul CellMouseClick din DatagridView numit dgp
        private void dgp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Se afiseaza Comment-urile pentru Post-ul selectat
            dgc.DataSource = null;
            dgc.DataSource = posts[e.RowIndex].Comments;
        }

    }
}

