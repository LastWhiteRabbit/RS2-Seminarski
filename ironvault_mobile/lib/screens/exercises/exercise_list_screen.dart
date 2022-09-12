import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:ironvault_mobile/login_page.dart';
import 'package:ironvault_mobile/model/exercise.dart';
import 'package:ironvault_mobile/model/exercisetype.dart';
import 'package:ironvault_mobile/model/muscle.dart';
import 'package:ironvault_mobile/providers/exercise_provider.dart';
import 'package:ironvault_mobile/providers/exercisetype_provider.dart';
import 'package:ironvault_mobile/providers/muscle_provider.dart';
import 'package:ironvault_mobile/providers/routine_provider.dart';
import 'package:ironvault_mobile/providers/routineclient_provider.dart';
import 'package:ironvault_mobile/widgets/ironvault_drawer.dart';
import 'package:ironvault_mobile/widgets/iv_drawer.dart';
import 'package:ironvault_mobile/widgets/master_screen.dart';
import 'package:provider/provider.dart';
import 'package:ironvault_mobile/utils/util.dart';

import 'exercise_details_screen.dart';

class ExerciseListScreen extends StatefulWidget {
  static const String routeName = "/exercises";

  const ExerciseListScreen({Key? key}) : super(key: key);

  @override
  State<ExerciseListScreen> createState() => _ExerciseListScreenState();
}

class _ExerciseListScreenState extends State<ExerciseListScreen> {
  ExerciseProvider? _exerciseProvider = null;
  RoutineClientProvider? _routineClientProvider = null;
  ExerciseTypeProvider? _exerciseTypeProvider = null;
  List<Exercise> data = [];
  List<ExerciseType> exerciseTypes = [];
  int? selectedExerciseTypeValue;

  double _drawerIconSize = 24;
  double _drawerFontSize = 17;
  @override
  void initState() {
    super.initState();
    _exerciseProvider = context.read<ExerciseProvider>();
    _routineClientProvider = context.read<RoutineClientProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _exerciseProvider?.get(null);

    setState(() {
      data = tmpData!;
    });
  }

  Future loadExerciseTypes() async {
    var tmpData = await _exerciseTypeProvider?.get(null);

    setState(() {
      exerciseTypes = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: SingleChildScrollView(
        child: Container(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              _buildHeader(),
              Text(data.length.toString()),
              Container(
                height: 500,
                child: GridView(
                  gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                      crossAxisCount: 1,
                      childAspectRatio: 4 / 3,
                      crossAxisSpacing: 1.0,
                      mainAxisSpacing: 1.0),
                  scrollDirection: Axis.vertical,
                  children: _buildExerciseCardList(),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Exercises",
        style: TextStyle(
            color: Colors.grey, fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }

  List<DropdownMenuItem> _buildExerciseTypesDownList() {
    if (exerciseTypes.isEmpty) {
      return [];
    }
    List<DropdownMenuItem> list = <DropdownMenuItem>[];

    list.add(DropdownMenuItem(
        child: Text("Exercise type", style: TextStyle(color: Colors.black)),
        enabled: false,
        value: -1));

    list.addAll(exerciseTypes
        .map((x) => DropdownMenuItem(
              child: Text(x.exerciseTypeName!,
                  style: TextStyle(color: Colors.black)),
              value: x.exerciseTypeId,
            ))
        .toList());

    return list;
  }

  List<Widget> _buildExerciseCardList() {
    if (data.length == 0) {
      return [Text("Loading...")];
    }
    List<Widget> list = data
        .map((x) => Container(
                child: Column(
              children: [
                InkWell(
                  onTap: () => {
                    Navigator.pushNamed(context,
                        "${ExerciseDetailsScreen.routeName}/${x.exerciseId}")
                  },
                  child: Container(
                    height: 100,
                    width: 100,
                    child: imageFromBase64String(x.exerciseImage!),
                  ),
                ),
                Text(x.exerciseName!),
                Text(x.muscleNames!),
                Text(x.typeNames!),
                IconButton(
                    onPressed: (() => _routineClientProvider?.addToRoutine(x)),
                    icon: Icon(Icons.add))
              ],
            )))
        .cast<Widget>()
        .toList();

    return list;
  }
}
