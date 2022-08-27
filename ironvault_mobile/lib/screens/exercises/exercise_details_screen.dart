import 'package:flutter/cupertino.dart';
import 'package:ironvault_mobile/widgets/master_screen.dart';

class ExerciseDetailsScreen extends StatefulWidget {
  static const String routeName = "/ExerciseDetails";
  String id;
  ExerciseDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<ExerciseDetailsScreen> createState() => _ExerciseDetailsScreenState();
}

class _ExerciseDetailsScreenState extends State<ExerciseDetailsScreen> {
  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Center(
        child: Text(this.widget.id),
      ),
    );
  }
}
