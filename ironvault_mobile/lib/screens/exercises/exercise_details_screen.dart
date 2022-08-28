import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:ironvault_mobile/model/exercise.dart';
import 'package:ironvault_mobile/providers/exercise_provider.dart';
import 'package:ironvault_mobile/providers/routineclient_provider.dart';
import 'package:ironvault_mobile/utils/util.dart';
import 'package:ironvault_mobile/widgets/master_screen.dart';
import 'package:provider/provider.dart';

class ExerciseDetailsScreen extends StatefulWidget {
  static const String routeName = "/ExerciseDetails";
  String id;
  ExerciseDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<ExerciseDetailsScreen> createState() => _ExerciseDetailsScreenState();
}

class _ExerciseDetailsScreenState extends State<ExerciseDetailsScreen> {
  ExerciseProvider? _exerciseProvider;
  RoutineClientProvider? _routineClientProvider = null;

  Exercise? data;
  Exercise? recommendedExercise;

  @override
  void initState() {
    super.initState();
    _exerciseProvider = context.read<ExerciseProvider>();
    _routineClientProvider = context.read<RoutineClientProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _exerciseProvider?.getById(int.parse(widget.id));
    var tmpRecommendedExercise = await _exerciseProvider
        ?.getRecommendedExercise(int.parse(widget.id) - 1);
    setState(() {
      data = tmpData!;
      recommendedExercise = tmpRecommendedExercise;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (data == null) {
      return const Text('');
    }

    return MasterScreenWidget(
      child: SingleChildScrollView(
        child: Container(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              _buildHeader(),
              SizedBox(height: 30.0),
              Container(
                child: TextFormField(
                  readOnly: true,
                  maxLines: null,
                  initialValue: data?.about,
                  decoration: InputDecoration(
                    labelText: 'About',
                    border: OutlineInputBorder(),
                  ),
                  style: TextStyle(
                    fontSize: 20,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ),
              SizedBox(height: 30.0),
              Row(
                children: [
                  Container(
                    height: 200,
                    width: 200,
                    child: imageFromBase64String(data?.exerciseImage ?? ""),
                  ),
                  Expanded(
                    child: Container(
                      child: TextFormField(
                        readOnly: true,
                        maxLines: 8,
                        initialValue: data?.instruction,
                        decoration: InputDecoration(
                          labelText: 'Instruction',
                          border: OutlineInputBorder(),
                        ),
                        style: TextStyle(
                          fontSize: 20,
                          fontWeight: FontWeight.bold,
                        ),
                      ),
                    ),
                  ),
                ],
              ),
              SizedBox(height: 30.0),
              Row(
                children: [
                  Column(
                    children: [
                      Text(
                        "Alternative exercise: ",
                        style: TextStyle(
                            color: Colors.black,
                            fontSize: 20,
                            fontWeight: FontWeight.w600),
                      ),
                      Container(
                        height: 150,
                        width: 150,
                        child: imageFromBase64String(
                            recommendedExercise?.exerciseImage ?? ""),
                      ),
                    ],
                  ),
                  Column(
                    children: [
                      Container(
                        child: Text(
                          "Add to my routine",
                          style: TextStyle(
                            fontSize: 17,
                          ),
                        ),
                      ),
                      TextButton(
                        style: TextButton.styleFrom(
                          backgroundColor: Colors.amber,
                          shape: CircleBorder(),
                        ),
                        child: Icon(
                          Icons.add,
                          color: Colors.white,
                        ),
                        onPressed: (() =>
                            _routineClientProvider?.addToRoutine(data!)),
                      )
                    ],
                  ),
                ],
              ),
              Container(
                child: Text(
                  "test",
                  style: TextStyle(
                    fontSize: 17,
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
    return MasterScreenWidget(
      child: Center(
        child: Text(this.widget.id),
      ),
    );
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "${data?.exerciseName}",
        style: TextStyle(
            color: Colors.grey, fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }
}
