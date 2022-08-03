import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:ironvault_mobile/providers/exercise_provider.dart';
import 'package:provider/provider.dart';

class ExerciseListScreen extends StatefulWidget {
  static const String routeName = "/exercises";

  const ExerciseListScreen({Key? key}) : super(key: key);

  @override
  State<ExerciseListScreen> createState() => _ExerciseListScreenState();
}

class _ExerciseListScreenState extends State<ExerciseListScreen> {
  ExerciseProvider? _exerciseProvider = null;
  dynamic data = {};

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

  List<Widget> _buildExerciseCardList() {
    if (data.length == 0) {
      return [Text("Loading...")];
    }
    List<Widget> list = data
        .map((x) => Container(
              height: 200,
              width: 200,
              child: Text(x["exerciseName"] ?? ""),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}
