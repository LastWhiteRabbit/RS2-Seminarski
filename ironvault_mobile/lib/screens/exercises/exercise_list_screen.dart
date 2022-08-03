import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:ironvault_mobile/providers/exercise_provider.dart';
import 'package:provider/provider.dart';

class ExerciseListScreen extends StatefulWidget {
  const ExerciseListScreen({Key? key}) : super(key: key);

  static const String routeName = "/exercises";

  @override
  State<ExerciseListScreen> createState() => _ExerciseListScreenState();
}

class _ExerciseListScreenState extends State<ExerciseListScreen> {
  ExerciseProvider? _exerciseProvider = null;
  String data = "";

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _exerciseProvider = context.read<ExerciseProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _exerciseProvider?.get(null);

    setState(() {
      data = tmpData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(child: Text(data)),
    );
  }
}
