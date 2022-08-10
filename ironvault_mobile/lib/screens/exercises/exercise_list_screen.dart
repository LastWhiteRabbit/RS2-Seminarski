import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:ironvault_mobile/model/exercise.dart';
import 'package:ironvault_mobile/providers/exercise_provider.dart';
import 'package:provider/provider.dart';
import 'package:ironvault_mobile/utils/util.dart';

class ExerciseListScreen extends StatefulWidget {
  static const String routeName = "/exercises";

  const ExerciseListScreen({Key? key}) : super(key: key);

  @override
  State<ExerciseListScreen> createState() => _ExerciseListScreenState();
}

class _ExerciseListScreenState extends State<ExerciseListScreen> {
  ExerciseProvider? _exerciseProvider = null;
  List<Exercise> data = [];

  @override
  void initState() {
    super.initState();
    _exerciseProvider = context.read<ExerciseProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _exerciseProvider?.get(null);

    setState(() {
      data = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SafeArea(
      child: SingleChildScrollView(
        child: Container(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              _buildHeader(),
              Container(
                height: 200,
                child: GridView(
                  gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                      crossAxisCount: 1,
                      childAspectRatio: 4 / 3,
                      crossAxisSpacing: 20,
                      mainAxisSpacing: 30),
                  scrollDirection: Axis.horizontal,
                  children: _buildExerciseCardList(),
                ),
              )
            ],
          ),
        ),
      ),
    ));
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

  List<Widget> _buildExerciseCardList() {
    if (data.length == 0) {
      return [Text("Loading...")];
    }
    List<Widget> list = data
        .map((x) => Container(
                child: Column(
              children: [
                Container(
                  height: 100,
                  width: 100,
                  child: imageFromBase64String(x.exerciseImage!),
                ),
                Text(x.exerciseName!),
                Text(x.muscleNames!),
                Text(x.typeNames!)
              ],
            )))
        .cast<Widget>()
        .toList();

    return list;
  }
}
