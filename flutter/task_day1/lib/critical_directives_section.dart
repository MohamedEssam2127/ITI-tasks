import 'package:flutter/material.dart';

class CriticalDirectivesSection extends StatelessWidget {
  const CriticalDirectivesSection({super.key});

  @override
  Widget build(BuildContext context) {
    final colorScheme = Theme.of(context).colorScheme;
    return Card(
      color: colorScheme.surface,
      elevation: 4,
      shadowColor: colorScheme.shadow.withOpacity(0.08),
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(16),
        side: BorderSide(
          color: colorScheme.outlineVariant,
          width: 1.0,
        ),
      ),
      child: Padding(
        padding: const EdgeInsets.symmetric(vertical: 16),
        child: Column(
          children: [
            Padding(
              padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
              child: Text(
                'Critical Directives Queue',
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.bold,
                  color: colorScheme.primary,
                ),
              ),
            ),
            const SizedBox(height: 8),
            ListTile(
              leading: CircleAvatar(
                backgroundColor: colorScheme.primary.withOpacity(0.1),
                child: Icon(Icons.storage, size: 24, color: colorScheme.primary),
              ),
              title: Text(
                'Database Consolidation',
                style: TextStyle(
                  fontWeight: FontWeight.bold,
                  fontSize: 16,
                  color: colorScheme.onSurface,
                ),
              ),
              subtitle: Text(
                'Optimization in progress',
                style: TextStyle(color: colorScheme.onSurfaceVariant),
              ),
              trailing: Icon(
                Icons.arrow_forward_ios,
                size: 16,
                color: colorScheme.onSurfaceVariant,
              ),
            ),
            Divider(height: 16, color: colorScheme.outlineVariant),
            ListTile(
              leading: CircleAvatar(
                backgroundColor: colorScheme.primary.withOpacity(0.1),
                child: Icon(Icons.account_tree, size: 24, color: colorScheme.primary),
              ),
              title: Text(
                'Network Link Stability',
                style: TextStyle(
                  fontWeight: FontWeight.bold,
                  fontSize: 16,
                  color: colorScheme.onSurface,
                ),
              ),
              subtitle: Text(
                'Monitoring connections',
                style: TextStyle(color: colorScheme.onSurfaceVariant),
              ),
              trailing: Icon(
                Icons.arrow_forward_ios,
                size: 16,
                color: colorScheme.onSurfaceVariant,
              ),
            ),
            Divider(height: 16, color: colorScheme.outlineVariant),
            ListTile(
              leading: CircleAvatar(
                backgroundColor: colorScheme.primary.withOpacity(0.1),
                child: Icon(Icons.shield, size: 24, color: colorScheme.primary),
              ),
              title: Text(
                'Firewall Rules Update',
                style: TextStyle(
                  fontWeight: FontWeight.bold,
                  fontSize: 16,
                  color: colorScheme.onSurface,
                ),
              ),
              subtitle: Text(
                'Applying new policies',
                style: TextStyle(color: colorScheme.onSurfaceVariant),
              ),
              trailing: Icon(
                Icons.arrow_forward_ios,
                size: 16,
                color: colorScheme.onSurfaceVariant,
              ),
            ),
          ],
        ),
      ),
    );
  }
}
