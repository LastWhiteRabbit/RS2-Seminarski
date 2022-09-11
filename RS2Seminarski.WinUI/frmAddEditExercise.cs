using RS2Seminarski.Model;
using RS2Seminarski.Model.Requests;
using RS2Seminarski.WinUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS2Seminarski.WinUI
{
    public partial class frmAddEditExercise : Form
    {
        public APIService ExerciseService { get; set; } = new APIService("Exercise");
        public APIService TypeService { get; set; } = new APIService("ExerciseType");
        public APIService MuscleService { get; set; } = new APIService("Muscle");
        public APIService LevelService { get; set; } = new APIService("Level");
        
        private Exercise _model = null;
        public frmAddEditExercise(Exercise model = null)
        {
            InitializeComponent();
            _model = model;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void btnSaveChangesAddExercise_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var typeList = clbTypes.CheckedItems.Cast<ExerciseType>().ToList();
                var typeIdList = typeList.Select(x => x.ExerciseTypeId).ToList();

                var muscleList = clbMuscles.CheckedItems.Cast<Muscle>().ToList();
                var muscleIdList = muscleList.Select(x => x.MuscleId).ToList();

                if (_model == null)
                {
                    ExerciseInsertRequest insertRequest = new ExerciseInsertRequest()
                    {
                        ExerciseName = txtName.Text,
                        About = txtAbout.Text,
                        Instruction = txtInstruction.Text,
                        LevelId = cmbLevel.SelectedIndex,
                        ExerciseTypeIdList = typeIdList,
                        MuscleIdList = muscleIdList
                        
                        //ExerciseImage
                    };

                    var exercise = await ExerciseService.Post<Exercise>(insertRequest);
                }

                else
                {
                    ExerciseUpdateRequest updateRequest = new ExerciseUpdateRequest
                    {
                        ExerciseName = txtName.Text,
                        About = txtAbout.Text,
                        Instruction = txtInstruction.Text

                    };
                    _model = await ExerciseService.Put<Exercise>(_model.ExerciseId, updateRequest);
                }
            }
        }


        private async void frmAddEditExercise_Load(object sender, EventArgs e)
        {
            await LoadTypesMuscles();

            if (_model != null)
            {
                txtName.Text = _model.ExerciseName;
                txtAbout.Text = _model.About;
                txtInstruction.Text = _model.Instruction;
            }
        }

        private async Task LoadTypesMuscles()
        {
            var types = await TypeService.Get<List<ExerciseType>>();
            clbTypes.DataSource = types;
            clbTypes.DisplayMember = "ExerciseTypeName";

            var muscles = await MuscleService.Get<List<Muscle>>();
            clbMuscles.DataSource = muscles;
            clbMuscles.DisplayMember = "MuscleName";

            var levels = await LevelService.Get<List<Level>>();
            cmbLevel.DataSource = levels;
            cmbLevel.DisplayMember = "LevelName";
            cmbLevel.ValueMember = "LevelId";
        }
    }
}
